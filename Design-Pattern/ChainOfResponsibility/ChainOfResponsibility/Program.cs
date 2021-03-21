using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leave = new LeaveRequest()
            {
                LeaveDays = 5,
                Employee = "Sudharsan"
            };
            ILeaveRequestHandler leaves = new Supervisor();
            leaves.HandlerRequest(leave);

            Console.ReadLine();
        }
    }
}
