using System;
using TowerApp.Repositories;
using TowerApp.Models;

namespace TowerApp.Services
{
    public class ProfileService
    {
        private readonly ProfileRepository _profRepo;
        public ProfileService(ProfileRepository profRepo)
        {
            _profRepo = profRepo;
        }
        internal Profile GetProfileById(string id)
        {
            Profile profile = _profRepo.GetById(id);
            if (profile == null)
            {
                throw new Exception("Invalid Id");
            }
            return profile;
        }
    }
}