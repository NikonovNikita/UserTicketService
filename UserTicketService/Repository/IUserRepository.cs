﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Repository;

public interface IUserRepository
{
    IEnumerable<User> FindAll();
}
