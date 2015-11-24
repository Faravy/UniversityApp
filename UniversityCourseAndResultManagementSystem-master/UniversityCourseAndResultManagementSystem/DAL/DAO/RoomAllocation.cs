using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseAndResultManagementSystem.DAL.DAO
{
    class RoomAllocation
    {
        public RoomAllocation()
        {
        }
        public int Id { get; set; }
        public int DeptId { get; set; }
        public int CourseId { get; set; }
        public int RoomId { get; set; }
        public string Day { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }

        public RoomAllocation(int deptId, int courseId, int roomId, string day, DateTime fromTime, DateTime toTime)
        {
            DeptId = deptId;
            CourseId = courseId;
            RoomId = roomId;
            Day = day;
            FromTime = fromTime;
            ToTime = toTime;
        }
    }
}
