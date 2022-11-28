using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAgencyRepository Agency { get; }
        ICityRepository City { get; }
        IClientRepository Client { get; }
        IGarage Garage { get; }
        IMotorcycle Motorcycle { get; }
        IPhones Phones { get; }
        IRent Rent { get; }

        void Save();
    }
}
