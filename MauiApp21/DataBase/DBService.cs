using JetBrains.Annotations;
using MauiApp21.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp21.DataBase
{
    public class DBService
    {
        //DB Name
        private const string DataBaseName = "ClientDitails";

        //Connection of the DB
        private readonly SQLiteAsyncConnection _databaseConnect;

        //Constructor
        public DBService()
        {
            _databaseConnect = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DataBaseName));
            _ = _databaseConnect.CreateTableAsync<ClientDetails>().ConfigureAwait(false);


        }

        //Create a list to store data
        public async Task<List<ClientDetails>> GetClientDetails()
        {
            return await _databaseConnect.Table<ClientDetails>().ToListAsync();

        }

        //DB Create, update, delete, display)

        //display or read from DB
        public async Task<ClientDetails> GetClientById(int id)
        {
            return await _databaseConnect.Table<ClientDetails>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        //create a client records

        public async Task Create(ClientDetails clientDetails)
        {
            await _databaseConnect.InsertAsync(clientDetails);
        }

        //update client details
        public async Task Update(ClientDetails clientDetails)
        {
            await _databaseConnect.UpdateAsync(clientDetails);
        }

        //delete client details
        public async Task Delete(ClientDetails clientDetails)
        {
            await _databaseConnect.DeleteAsync(clientDetails);

        }
        //display client details
        public async Task Display(ClientDetails clientDetails)
        {
            
        }
    }
}
