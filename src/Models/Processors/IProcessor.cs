//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Trestlebridge.Models.Processors
//{
//    public interface IProcessor
//    {
//        int Capacity { get; set; }
//        void Process(IResource resource, int count)
//        {
//            foreach (var product in resource.Product)
//            {
//                Type t = GetType();
//                PropertyInfo p = t.GetProperty(product.Key);
//                if (p.ToString() == product.Key)
//                {
//                    p.SetValue(p, +product.Value);
//                }
//            }
//        }
//    }
//}