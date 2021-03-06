﻿using System.Collections.Generic;
using BlackJack.DAL.Enteties;

namespace BlackJack.DAL.Interfaces
{
  public interface IUserRepository : IRepository<User>
  {
    IEnumerable<User> GetAllUsersWithCards();
    User GetCardsOfUser(int? id);
  }
}
