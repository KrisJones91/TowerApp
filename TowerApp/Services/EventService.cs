using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TowerApp.Models;
using TowerApp.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TowerApp.Services
{
    public class EventService
    {
        private readonly EventsRepository _eventsrepo;
        public EventService(EventsRepository eventsrepo)
        {
            _eventsrepo = eventsrepo;
        }
        public IEnumerable<TowerEvent> getAllEvents()
        {
            return _repo.getAllEvents();
        }
    }

}