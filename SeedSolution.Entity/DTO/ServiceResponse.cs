using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SeedSolution.Entity.DTO
{
    [Serializable]
    [DataContract]
    public class ServiceResponse
    {
        [DataMember]
        public int ResponseStatus { get; set; } //200 Exito -- 400 Error
        [DataMember]
        public string ResponseMessage { get; set; }
        [DataMember]
        public object Result { get; set; }       
    }
}
