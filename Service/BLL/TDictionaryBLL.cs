﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL;
using Model;
namespace BLL
{
    public class TDictionaryBLL:IUploadData
    {
        public TDictionaryBLL()
        {
        }

        #region CommonMethods

        public List<TDictionaryModel> GetModelList()
        {
            return new TDictionaryDAL().GetModelList();
        }

        public List<TDictionaryModel> GetModelList(Expression<Func<TDictionaryModel, bool>> predicate)
        {
            return new TDictionaryDAL().GetModelList(predicate);
        }

        public TDictionaryModel GetModel(int id)
        {
            return new TDictionaryDAL().GetModel(id);
        }

        public TDictionaryModel Insert(TDictionaryModel model)
        {
            return new TDictionaryDAL().Insert(model);
        }

        public int Update(TDictionaryModel model)
        {
            return new TDictionaryDAL().Update(model);
        }

        public int Delete(TDictionaryModel model)
        {
            return new TDictionaryDAL().Delete(model);
        }

        #endregion

        public List<TDictionaryModel> GetModelList(string name)
        {
            return new TDictionaryDAL().GetModelList(name);
        }

   

        public bool IsBasic
        {
            get { return false; }
        }

        public bool ProcessInsertData(int areaCode,  string targetDbName)
        {
            try
            {
                var sList = new TDictionaryDAL(areaCode.ToString()).GetModelList(c => c.sysFlag == 0).ToList();
                sList.ForEach(s =>
                {
                    s.areaCode = areaCode;
                    s.areaId = s.ID;
                });
                var dal = new TDictionaryDAL(targetDbName);
                foreach (var s in sList)
                {
                    dal.Insert(s);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ProcessUpdateData(int areaCode,   string targetDbName)
        {
            return true;
        }

        public bool ProcessDeleteData(int areaCode,  string targetDbName)
        {
            return true;
        }
    }
}
