using Animal_Model;
using CKM_CommonFunction;
using CKM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Animal_BL
{
    public class AnimalBL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public AnimalBL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        public JObject GetAnimal(AnimalModel animalModel)
        {
            // return "testApi";
            animalModel.Sqlprms = new SqlParameter[1];
            animalModel.Sqlprms[0] = new SqlParameter("@AnimalCD", animalModel.AnimalCD);
            string str = cKMDL.SelectJson("Animal_Select", ff.GetConnectionWithDefaultPath("ReactTest"), animalModel.Sqlprms);
            var jObject = JObject.Parse(str);
            return jObject;
        }
        public string AnimalCUD(AnimalModel animalModel)
        {
            cKMDL.UseTran = true;
            animalModel.Sqlprms = new SqlParameter[4];
            animalModel.Sqlprms[0] = new SqlParameter("@AnimalCD", animalModel.AnimalCD);
            animalModel.Sqlprms[1] = new SqlParameter("@AnimalName", animalModel.AnimalName);
            animalModel.Sqlprms[2] = new SqlParameter("@Description", animalModel.Description);
            animalModel.Sqlprms[3] = new SqlParameter("@Mode", animalModel.Mode);
            return cKMDL.InsertUpdateDeleteData("Animal_CUD", ff.GetConnectionWithDefaultPath("ReactTest"), animalModel.Sqlprms);
        }
        public string GetTestApi(AnimalModel animalModel)
        {
            return "gettestapi";
        }
    }
}
