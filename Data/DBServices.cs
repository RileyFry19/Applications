using ApplicationsRiley.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationsRiley.Data;

public class DBServices
{
    private readonly DataContext dataContext;

    public DBServices(DataContext _dataContext)
    {
        dataContext = _dataContext;
    }
    
    public async Task<List<Apps>> GetAppsAsync()
    {
        // Fetch apps from the database asynchronously
        return await dataContext.apps.ToListAsync();
    }
    public void SaveData(Apps app)
    {
        app.AppId = Guid.NewGuid();
        dataContext.apps.Add(app);
        dataContext.SaveChanges();
    }
    
    public void DeleteData(Guid id)
    {
        dataContext.apps.Remove(dataContext.apps.FirstOrDefault(app => app.AppId == id));
        dataContext.SaveChanges();
    }
}