using CKM_CommonFunction;
using CKM_DataLayer;
using System.Data.SqlClient;
using TestingModel;


namespace TestingBL
{
    public class Testing_BL
    {
        CKMDL cKMDL;
        FileFunction ff;
        public Testing_BL()
        {
            cKMDL = new CKMDL();
            ff = new FileFunction();
        }
        //public string TestingInsert(Testing_Model testingmodel)
        //{
        //    cKMDL.UseTran = true;
        //    testingmodel.Sqlprms = new SqlParameter[3];
        //    testingmodel.Sqlprms[0] = new SqlParameter("@ID", testingmodel.ID);
        //    testingmodel.Sqlprms[1] = new SqlParameter("@Title", testingmodel.Title);
        //    testingmodel.Sqlprms[2] = new SqlParameter("@Description", testingmodel.Description);


        //    return cKMDL.InsertUpdateDeleteData("TestingInsert", ff.GetConnectionWithDefaultPath("TestingApi"), testingmodel.Sqlprms);
        //}

        //public string TestingUpdate(Testing_Model testingmodel)
        //{
        //    cKMDL.UseTran = true;
        //    testingmodel.Sqlprms = new SqlParameter[3];
        //    testingmodel.Sqlprms[0] = new SqlParameter("@ID", testingmodel.ID);
        //    testingmodel.Sqlprms[1] = new SqlParameter("@Title", testingmodel.Title);
        //    testingmodel.Sqlprms[2] = new SqlParameter("@Description", testingmodel.Description);


        //    return cKMDL.InsertUpdateDeleteData("TestingUpdate", ff.GetConnectionWithDefaultPath("TestingApi"), testingmodel.Sqlprms);
        //}

        //public string TestingDelete(Testing_Model testingmodel)
        //{
        //    cKMDL.UseTran = true;
        //    testingmodel.Sqlprms = new SqlParameter[3];
        //    testingmodel.Sqlprms[0] = new SqlParameter("@ID", testingmodel.ID);
        //    testingmodel.Sqlprms[1] = new SqlParameter("@Title", testingmodel.Title);
        //    testingmodel.Sqlprms[2] = new SqlParameter("@Description", testingmodel.Description);


        //    return cKMDL.InsertUpdateDeleteData("TestingDelete", ff.GetConnectionWithDefaultPath("TestingApi"), testingmodel.Sqlprms);
        //}

        public string TestingCUD(Testing_Model testingmodel)
        {
            cKMDL.UseTran = true;
            testingmodel.Sqlprms = new SqlParameter[4];
            testingmodel.Sqlprms[0] = new SqlParameter("@ID", testingmodel.ID);
            testingmodel.Sqlprms[1] = new SqlParameter("@Title", testingmodel.Title);
            testingmodel.Sqlprms[2] = new SqlParameter("@Description", testingmodel.Description);
            testingmodel.Sqlprms[3] = new SqlParameter("@Mode", testingmodel.Mode);


            return cKMDL.InsertUpdateDeleteData("TestingCUD", ff.GetConnectionWithDefaultPath("ReactTest"), testingmodel.Sqlprms);
        }

        public string TestingSelect(Testing_Model testingmodel)
        {
            cKMDL.UseTran = true;
            testingmodel.Sqlprms = new SqlParameter[0];
            //testingmodel.Sqlprms[0] = new SqlParameter("@ID", testingmodel.ID);

            return cKMDL.SelectJson("TestingSelect", ff.GetConnectionWithDefaultPath("ReactTest"), testingmodel.Sqlprms);
        }
    }
}
