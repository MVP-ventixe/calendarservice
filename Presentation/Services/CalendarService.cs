using System.Globalization;
using Grpc.Core;

namespace Presentation.Services;

public class CalendarService : CalendarHandler.CalendarHandlerBase
{

    private List<Calendar> _calendars = new List<Calendar>
    {
        new Calendar
        {
            Id = "1",
            name = "Meeting with Bob",
            description = "Discuss project updates",
            date = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"), 
            time = DateTime.Now.AddHours(2).ToString("HH:mm")     
        }
    };

    public override Task<GetCalendarResponse> GetCalendar(GetCalendarRequest request, ServerCallContext context)
    {
        var response = new GetCalendarResponse();
        response.Calendars.AddRange(_Calendars);
        

    }

    public override Task<CreateCalendarRequest>  
}
