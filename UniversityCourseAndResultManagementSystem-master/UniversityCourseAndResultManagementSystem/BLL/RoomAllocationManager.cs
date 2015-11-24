using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;
using UniversityCourseAndResultManagementSystem.DAL.Gateway;

namespace UniversityCourseAndResultManagementSystem.BLL
{
    class RoomAllocationManager
    {
        RoomAllocationGateway gateway=new RoomAllocationGateway();
        public bool Save(RoomAllocation roomAllocation)
        {

            if (IsCourseAlreadyExist(roomAllocation.CourseId))
            {
                throw new Exception("Course Already Allocated");
            }
            return gateway.Save(roomAllocation) > 0;
        }

        public bool IsCourseAlreadyExist(int courseId)
        {
            return gateway.IsCourseAlreadyExist(courseId) > 0;
        }

        public List<Room> GetAllRoom()
        {
            return gateway.GetAllRooms();
        }

        private List<RoomAllocation> GetAllAllocatedRoom()
        {
            return gateway.GetAllAllocatedRooms();
        }

        public bool IsRoomAvailable(int roomId,string day,DateTime fromTime,DateTime totTime)
        {
            List<RoomAllocation> alloCatedRoom = GetAllAllocatedRoom();
            bool isAvailable = false;

            if (alloCatedRoom != null)
                
            {
                alloCatedRoom = alloCatedRoom.Where(a => a.RoomId == roomId && a.Day == day).ToList();
            }

            return true;
        }
    }
}
