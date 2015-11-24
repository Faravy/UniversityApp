using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCourseAndResultManagementSystem.DAL.DAO;

namespace UniversityCourseAndResultManagementSystem.DAL.Gateway
{
    class RoomAllocationGateway:Gateway
    {
        public int Save(RoomAllocation roomAllocation)
        {
            string query = "INSERT INTO t_room_allocation VALUES('" + roomAllocation.DeptId + "', '" + roomAllocation.CourseId + "', '" + roomAllocation.RoomId + "', '" + roomAllocation.Day + "', '" + roomAllocation.FromTime + "', '" + roomAllocation.ToTime + "')";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            int rowAffected = aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            return rowAffected;
        }
        public int IsCourseAlreadyExist(int courseId)
        {
            string query = "SELECT * FROM t_room_allocation WHERE course_id='" + courseId + "'";
            aSqlConnection.Open();
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            if (aSqlDataReader.HasRows)
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return 1;
            }
            else
            {
                aSqlDataReader.Close();
                aSqlConnection.Close();
                return -1;
            }
        }
        public List<Room> GetAllRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "SELECT * FROM t_room";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                Room room = new Room();
                room.Id = (int)aSqlDataReader["id"];
                room.Name = aSqlDataReader["name"].ToString();

                roomList.Add(room);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return roomList;
        }

        public List<RoomAllocation> GetAllAllocatedRooms()
        {
            List<RoomAllocation> allocatedRoomList = new List<RoomAllocation>();
            string query = "SELECT * FROM t_room_allocation";
            aSqlCommand = new SqlCommand(query, aSqlConnection);
            aSqlConnection.Open();
            SqlDataReader aSqlDataReader = aSqlCommand.ExecuteReader();

            while (aSqlDataReader.Read())
            {
                RoomAllocation roomAllocation = new RoomAllocation();
                roomAllocation.Id = (int)aSqlDataReader["id"];
                roomAllocation.DeptId =(int) aSqlDataReader["dept_id"];
                roomAllocation.CourseId = (int)aSqlDataReader["course_id"];
                roomAllocation.RoomId = (int)aSqlDataReader["room_id"];
                roomAllocation.Day = aSqlDataReader["day"].ToString();
                roomAllocation.FromTime = (DateTime)aSqlDataReader["from_time"];
                roomAllocation.ToTime = (DateTime)aSqlDataReader["to_time"];

                allocatedRoomList.Add(roomAllocation);
            }
            aSqlDataReader.Close();
            aSqlConnection.Close();

            return allocatedRoomList;

        } 
    }
}
