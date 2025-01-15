//using SQLite;
//using BCrypt.Net;

//namespace Course
//{
//    public class LocalDBService
//    {
//        private const string DB_NAME = "local.db";
//        private readonly SQLiteAsyncConnection? _connection;

//        public LocalDBService()
//        {
//            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
//            _connection.CreateTableAsync<Model.UserModel>();
//        }

//        // Method to create a user with a hashed password
//        public async Task CreateUserAsync(string username, string password, string currency)
//        {
//            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

//            var user = new Model.UserModel
//            {
//                Username = username,
//                Password = hashedPassword,
//                Currency = currency
//            };

//            await _connection.InsertAsync(user);
//        }

//        // Method to validate user credentials
//        public async Task<Model.UserModel?> ValidateUserAsync(string username, string password)
//        {
//            var user = await _connection.Table<Model.UserModel>()
//                .Where(u => u.Username == username)
//                .FirstOrDefaultAsync();

//            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
//            {
//                return user; // Password matches
//            }

//            return null; // Invalid credentials
//        }
//    }
//}
