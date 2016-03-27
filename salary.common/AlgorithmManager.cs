using System;
using System.Collections.Generic;
using SalarySystem.Algorithm;

namespace SalarySystem
{
    public class AlgorithmInfo
    {
        public AlgorithmInfo()
        {
            ParameterInfos = new List<IParameterInfo>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<IParameterInfo> ParameterInfos { get; private set; }
        public Type AlgorithmType;
    }
   public class AlgorithmManager
    {
       static readonly List<AlgorithmInfo> _algorithms=new List<AlgorithmInfo>();
       
       public static void Register(Type algorithm)
       {
           if (!algorithm.IsInstanceOfType(typeof (IAlgorithm)))
           {
               throw new InvalidCastException("算法注册失败，类型不支持算法接口！");
           }
           AlgorithmInfo algorithmInfo=new AlgorithmInfo();
           AlgorithmAttribute[] algorithmAttributes= algorithm.GetCustomAttributes(typeof (AlgorithmAttribute), true) as AlgorithmAttribute[];
           if (algorithmAttributes == null || algorithmAttributes.Length <= 0) return;
           algorithmInfo.Name = algorithmAttributes[0].Name;
           algorithmInfo.Description = algorithmAttributes[0].Description;
           ParameterAttribute[] parameters =
               algorithm.GetCustomAttributes(typeof (ParameterAttribute), true) as ParameterAttribute[];
           if (parameters != null)
           {
               foreach (var parameter in parameters)
               {
                   ITypeConverter converter = null;
                   if (parameter.ConverterType != null)
                   {
                       converter = Activator.CreateInstance(parameter.ConverterType) as ITypeConverter;
                   }
                   algorithmInfo.ParameterInfos.Add(new ParameterInfo("", parameter.Name, parameter.Description,
                       parameter.Type, converter));
               }
           }
           _algorithms.Add(algorithmInfo);
       }
        
    }
}
