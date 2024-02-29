using BusinessLogicLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService;
using IStore;
using StoreContainer;

namespace Service
{
    public class StudentService : ServiceBase<Student>, IStudentService

    {
        public StudentService() : base(IOCContainerStore.Resolve<IStudentStore>())
        {

        }
    }
}
