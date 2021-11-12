﻿using Animal_Model;
using CKM_CommonFunction;
using CKM_DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string GetAnimal(AnimalModel animalModel)
        {
            animalModel.Sqlprms = new SqlParameter[3];
            animalModel.Sqlprms[0] = new SqlParameter("@AnimalCD", animalModel.AnimalCD);
            animalModel.Sqlprms[1] = new SqlParameter("@AnimalName", animalModel.AnimalName);
            animalModel.Sqlprms[2] = new SqlParameter("@Description", animalModel.Description);
            return cKMDL.SelectJson("Animal_Select", ff.GetConnectionWithDefaultPath("TestingApi"), animalModel.Sqlprms);
        }
        public string AnimalCUD(AnimalModel animalModel)
        {
            cKMDL.UseTran = true;
            animalModel.Sqlprms = new SqlParameter[4];
            animalModel.Sqlprms[0] = new SqlParameter("@AnimalCD", animalModel.AnimalCD);
            animalModel.Sqlprms[1] = new SqlParameter("@AnimalName", animalModel.AnimalName);
            animalModel.Sqlprms[2] = new SqlParameter("@Description", animalModel.Description);
            animalModel.Sqlprms[3] = new SqlParameter("@Mode", animalModel.Mode);
            return cKMDL.InsertUpdateDeleteData("Animal_CUD", ff.GetConnectionWithDefaultPath("TestingApi"), animalModel.Sqlprms);
        }
    }
}
