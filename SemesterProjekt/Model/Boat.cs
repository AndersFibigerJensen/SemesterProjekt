﻿namespace SemesterProjekt.Model
{
    public class Boat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double Weight { get; set; }

        public int MinimumCrew { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Boat other = (Boat)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
