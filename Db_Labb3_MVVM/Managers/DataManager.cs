using System.Data;
using Db_Labb3_MVVM.Managers.Interfaces;
using Db_Labb3_MVVM.Models;

namespace Db_Labb3_MVVM.Services;

public class DataManager : IDataManager
{
    private readonly DataModel _dataModel = new DataModel();
    public DataModel DataModel => _dataModel;
}