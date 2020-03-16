using System.Collections.Generic;

namespace University.Models
{
    public class ResponseErrorModel
    {
        public int Code { get; set; }

        public string Description { get; set; }
    }

    public class ListOfErrorsResponeModel
    {
        public List<ResponseErrorModel> ErrorList { get; set; }
    }
}
