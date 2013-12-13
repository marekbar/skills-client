using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasksDesktopClient
{
    public static class Service
    {
        public static MBService.MBServiceClient Create()
        {
            try
            {
                MBService.MBServiceClient client = new MBService.MBServiceClient();

                return client;
            }
            catch
            {
                return null;
            }
        }
    }
}
