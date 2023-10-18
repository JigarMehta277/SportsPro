﻿namespace SportsPro.Models
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; } 
        public int ProductID { get; set; } 
        public int TechnicianID { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; } 
    }
}
