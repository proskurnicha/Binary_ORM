using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Binary_Project_Structure_DataAccess.Models;

namespace Binary_Project_Structure_DataAccess
{
    public class DataSource
    {
        public static List<Flight> Flights { get; set; }

        public static List<Ticket> Tickets { get; set; }

        public static List<Stewardess> Stewardesses { get; set; }

        public static List<Pilot> Pilots { get; set; }

        public static List<Departure> Departures { get; set; }

        public static List<Crew> Crews { get; set; }

        public static List<TypeAircraft> TypeAircrafts { get; set; }

        public static List<Aircraft> Aircrafts { get; set; }

        static DataSource()
        {
            if (Flights == null)
            {
                GenerateFlights();
                GenerateTickets();
                CreateConnectionFlightTicket();
                GenerateStewardess();
                GeneratePilots();
                GenerateCrews();
                GenerateTypeAircrafts();
                GenerateAircrafts();
                GenerateDepartures();
            }
        }

        #region GenerateFlightsAndTickets
        public static void GenerateFlights()
        {
            Flights = new List<Flight>();

            Flights.AddRange(new Flight[] { new Flight()
            {
                Id = 1,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Berlin",
                DepartureTime = new TimeSpan(4, 46, 0),
                ArrivalTime = new TimeSpan(10, 29, 0),
                TicketsId  = new List<int>(){1,2}
            },
            new Flight()
            {
                Id = 2,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Riga",
                DepartureTime = new TimeSpan(11, 30, 0),
                ArrivalTime = new TimeSpan(8, 05, 0),
                TicketsId  = new List<int>(){2, 3}
            },
            new Flight()
            {
                Id = 3,
                DeparturePoint = "Kiev",
                ArrivalPoint = "Brussels",
                DepartureTime = new TimeSpan(05, 48, 0),
                ArrivalTime = new TimeSpan(3, 15, 0),
                TicketsId  = new List<int>(){1, 3}
            }
            });
        }

        public static void GenerateTickets()
        {
            Tickets = new List<Ticket>();
            Tickets.AddRange(new Ticket[] {
                new Ticket()
                {
                    Id = 1,
                    Price = 200,
                    FlightId = 1,
                },
                new Ticket()
                {
                    Id = 2,
                    Price = 300,
                    FlightId = 2,
                },
                new Ticket()
                {
                    Id = 3,
                    Price = 400,
                    FlightId = 3,
                }
            });
        }

        public static void CreateConnectionFlightTicket()
        {
            Flights = Flights.GroupJoin(Tickets, x => x.Id, x => x.FlightId,
            (flight, tickets) => new Flight()
            {
                Id = flight.Id,
                ArrivalPoint = flight.ArrivalPoint,
                ArrivalTime = flight.ArrivalTime,
                DeparturePoint = flight.DeparturePoint,
                DepartureTime = flight.DepartureTime,
                Tickets = new List<Ticket>(tickets),
                TicketsId = flight.TicketsId
            }).ToList();
        }
        #endregion

        #region GenerateCrew
        public static void GenerateStewardess()
        {
            Stewardesses = new List<Stewardess>();
            Stewardesses.AddRange(new Stewardess[] {
                new Stewardess()
            {
                    Id = 1,
                    Name = "Natali",
                    Surname = "Sidorova",
                    DateBirth = new DateTime(1990, 12, 4)
            },
                 new Stewardess()
            {
                    Id = 2,
                    Name = "Kate",
                    Surname = "Petrova",
                    DateBirth = new DateTime(1995, 5, 15)
            },
                 new Stewardess()
            {
                    Id = 3,
                    Name = "Tanya",
                    Surname = "Durova",
                    DateBirth = new DateTime(1993, 7, 26)
            }
            });
        }

        public static void GeneratePilots()
        {
            Pilots = new List<Pilot>();
            Pilots.AddRange(new Pilot[] {
                new Pilot()
            {
                    Id = 1,
                    Name = "Ivan",
                    Surname = "Ivanov",
                    DateBirth = new DateTime(1990, 12, 4),
                    Experience = 5
            },
                 new Pilot()
            {
                    Id = 2,
                    Name = "Petr",
                    Surname = "Petrov",
                    DateBirth = new DateTime(1995, 5, 15),
                    Experience = 10
            },
                 new Pilot()
            {
                    Id = 3,
                    Name = "Sidr",
                    Surname = "Sidorov",
                    DateBirth = new DateTime(1993, 7, 26),
                    Experience = 7
            }
            });
        }

        public static void GenerateCrews()
        {
            Crews = new List<Crew>();
            Crews.AddRange(new Crew[] {
                new Crew()
                {
                    Id = 1,
                    PilotId = 1,
                    Stewardesses = DataSource.Stewardesses,
                    StewardessesId = new List<int>(){1,2,3}
                },
                new Crew()
                {
                    Id = 2,
                    PilotId = 2,
                    Stewardesses = DataSource.Stewardesses,
                    StewardessesId = new List<int>(){1,2,3}
                },
                new Crew()
                {
                    Id = 3,
                    PilotId = 3,
                    Stewardesses = DataSource.Stewardesses,
                    StewardessesId = new List<int>(){1,2,3}
                }
            });
        }

        #endregion

        #region GenerateAircraft
        public static void GenerateTypeAircrafts()
        {
            TypeAircrafts = new List<TypeAircraft>();
            TypeAircrafts.AddRange(new TypeAircraft[] {
                new TypeAircraft()
                {
                    Id = 1,
                    AircraftModel = AircraftModel.IL_96_300,
                    NumberPlaces = 797,
                    CarryingCapacity = 240000

                },
                new TypeAircraft()
                {
                    Id = 2,
                    AircraftModel = AircraftModel.Airbus_A310,
                    NumberPlaces = 183,
                    CarryingCapacity = 164000
                }
            });
        }

        public static void GenerateAircrafts()
        {
            Aircrafts = new List<Aircraft>();

            Aircrafts.AddRange(new Aircraft[]
            {
                new Aircraft()
                {
                    Id = 1,
                    TypeAircraftId = 1,
                    AircraftName = "Star",
                    DateRelease = new DateTime(1998, 05, 12),
                    Lifetime = new TimeSpan(1000, 0, 0, 0)
                },
                new Aircraft()
                {
                    Id = 2,
                    TypeAircraftId = 2,
                    AircraftName = "Cometa",
                    DateRelease = new DateTime(1991, 10, 03),
                    Lifetime = new TimeSpan(2500, 0, 0, 0)
                }
            });
        }
        #endregion

        #region GenerateDeparture

        public static void GenerateDepartures()
        {
            Departures = new List<Departure>();
            Departures.AddRange(new Departure[] {
                new Departure()
                {
                    Id = 1,
                    AircraftId = 1,
                    CrewId = 1,
                    FlightId = 1,
                    DepartureTime = new DateTime(2018, 07, 13)
                },
                new Departure()
                {
                    Id = 2,
                    AircraftId = 2,
                    CrewId = 2,
                    FlightId = 2,
                    DepartureTime = new DateTime(2018, 07, 15)
                },
                new Departure()
                {
                    Id = 3,
                    AircraftId = 1,
                    CrewId = 3,
                    FlightId = 3,
                    DepartureTime = new DateTime(2018, 07, 14)
                },
            });
        }
        #endregion

        public List<TEntity> Set<TEntity>()
        {

            if (Tickets is List<TEntity>)
                return Tickets as List<TEntity>;

            if (Stewardesses is List<TEntity>)
                return Stewardesses as List<TEntity>;

            if (Pilots is List<TEntity>)
                return Pilots as List<TEntity>;

            if (Departures is List<TEntity>)
                return Departures as List<TEntity>;

            if (Crews is List<TEntity>)
                return Crews as List<TEntity>;

            if (TypeAircrafts is List<TEntity>)
                return TypeAircrafts as List<TEntity>;

            if (Aircrafts is List<TEntity>)
                return Aircrafts as List<TEntity>;

            if (Flights is List<TEntity>)
                return Flights as List<TEntity>;

            return null;
        }
    }
}

