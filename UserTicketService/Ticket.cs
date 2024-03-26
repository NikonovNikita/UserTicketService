﻿namespace UserTicketService;

public class Ticket
{
    public int Id { get; }
    public string Description { get; }
    public int Price { get; }

    public Ticket(int id, string description, int price)
    {
        Id = id;
        Description = description;
        Price = price;
    }
}
