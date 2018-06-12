﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolExpress.Domain
{
    public class CourseScheduleDetail : Entity
    {
        private string _joinDays;

        public int Id { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string JoinDays
        {
            get => _joinDays;
            set
            {
                SplitDays(_joinDays);
                _joinDays = value;
            }
        }

        public int CourseScheduleId { get; set; }

        public virtual CourseSchedule CourseSchedule { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int ClassRoomId { get; set; }

        public virtual ClassRoom ClassRoom { get; set; }

        public int SpeakerId { get; set; }

        public virtual Speaker Speaker { get; set; }

        public IList<Day> Days { get; set; }

        public void SplitDays(string joinDays)
        {
            IList<string> days = joinDays.Split(',').ToList();
            foreach (string day in days)
                Days.Add(EnumUtil.Parse<Day>(day));
        }

        public override object[] GetId()
        {
            return new object[] {Id};
        }
    }
}