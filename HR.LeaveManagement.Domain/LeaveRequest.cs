using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        public DateTime DateRequest {  get; set; }
        public string? RequestComment {  get; set; }

        public bool? Approved { get; set; }
        public bool Canceled { get; set; }

        public string RequestEmployeeID {  get; set; }=String.Empty;
    }
   
}
