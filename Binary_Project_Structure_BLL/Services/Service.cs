using AutoMapper;
using Binary_Project_Structure_BLL.Interfaces;
using Binary_Project_Structure_DataAccess.Interfaces;
using Binary_Project_Structure_DataAccess.Models;
using Binary_Project_Structure_DataAccess.UnitOfWork;
using Binary_Project_Structure_Shared.DTOs;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Project_Structure_BLL.Services
{
    public class Service : IServiceCommon
    {
        IMapper iMapper;
        public IUnitOfWork context { get; private set; }

        public Service()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            context = ninjectKernel.Get<IUnitOfWork>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aircraft, AircraftDto>();
                cfg.CreateMap<AircraftDto, Aircraft>();
                cfg.CreateMap<Crew, CrewDto>();
                cfg.CreateMap<CrewDto, Crew>();
                cfg.CreateMap<Departure, DepartureDto>();
                cfg.CreateMap<DepartureDto, Departure>();
                cfg.CreateMap<Flight, FlightDto>();
                cfg.CreateMap<FlightDto, Flight>();
                cfg.CreateMap<Pilot, PilotDto>();
                cfg.CreateMap<PilotDto, Pilot>();
                cfg.CreateMap<Stewardess, StewardessDto>();
                cfg.CreateMap<StewardessDto, Stewardess>();
                cfg.CreateMap<Ticket, TicketDto>();
                cfg.CreateMap<TicketDto, Ticket>();
                cfg.CreateMap<TypeAircraft, TypeAircraftDto>();
                cfg.CreateMap<TypeAircraftDto, TypeAircraft>();
            });
            iMapper = config.CreateMapper();
        }

        public  List<TEntityDto> GetAll<TEntity, TEntityDto>() where TEntity : class
        {
            return iMapper.Map<List<TEntity>, List<TEntityDto>>(context.Set<IRepository<TEntity>>().GetAll());
        }

        public TEntityDto GetById<TEntity, TEntityDto>(Func<TEntity, bool> filter = null) where TEntity : class
        {
            return iMapper.Map<TEntity, TEntityDto>(context.Set<IRepository<TEntity>>().GetById(filter));
        }

        public void Update<TEntityDto, TEntity>(TEntityDto entityDto) where TEntity : class
        {
            TEntity entity = iMapper.Map<TEntityDto, TEntity>(entityDto);
            context.Set<IRepository<TEntity>>().Update(entity);
        }

        public void Create<TEntityDto, TEntity>(TEntityDto entityDto) where TEntity : class
        {
            TEntity entity = iMapper.Map<TEntityDto, TEntity>(entityDto);
            context.Set<IRepository<TEntity>>().Create(entity);
        }

        public bool Delete<TEntity>(Predicate<TEntity> prEntity) where TEntity : class
        {
            return context.Set<IRepository<TEntity>>().Delete(prEntity);
        }
    }
}
