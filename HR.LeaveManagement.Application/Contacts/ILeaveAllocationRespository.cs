using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Contacts
{
    public interface ILeaveAllocationRespository 
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails(string userID);
        Task<bool>AllocationExists(string userID,int leaveTypeID,int period);
        Task Addlocations(List<LeaveAllocation> allocations);
        Task<LeaveAllocation> GetUserAllocations(String userID, int leaveTypeID);
    }
}
