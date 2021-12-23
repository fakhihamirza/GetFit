using System;

namespace DataAccessLayer.DTO
{
    class ReadHistory
    {
        public DateTime Posted_At = DateTime.Now;
        public int food_id { get; set; }
        public string food_name { get; set; }
    }
}
