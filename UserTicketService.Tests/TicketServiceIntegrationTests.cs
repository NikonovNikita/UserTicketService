namespace UserTicketService.Tests;

public class TicketServiceIntegrationTests
{
    [Test]
    public void SaveTicketMustAddTicketInBase()
    {
        var ticketServiceTest = new TicketService();
        var newTicket = new Ticket(4, "Description", 1000);

        ticketServiceTest.SaveTicket(newTicket);

        var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
        CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

    }
}
