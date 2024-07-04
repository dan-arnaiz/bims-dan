using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace BIMS_dan {
internal class Authentication {
  private string connectionString =
      @"Server=localhost;Database=dan-bims;Integrated Security=True;";

  public bool Login(string username, string password) {
    // Hash the password
    var passwordHash = HashPassword(password);

    using (var connection = new SqlConnection(connectionString)) {
      connection.Open();
      var query = "SELECT COUNT(1) FROM SystemUsers WHERE Username = " +
                  "@Username AND PasswordHash = @PasswordHash AND IsActive = 1";

      using (var command = new SqlCommand(query, connection)) {
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@PasswordHash", passwordHash);

        var result = (int)command.ExecuteScalar();
        return result > 0;
      }
    }
  }

  private string HashPassword(string password) {
    using (var sha256 = SHA256.Create()) {
      var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
      var hash = BitConverter.ToString(hashedBytes)
                     .Replace("-", "")
                     .ToLowerInvariant();
      return hash;
    }
  }

  public bool SignUp(string username, string Email, string password) {
    // First, check if the user already exists to avoid duplicates
    if (UserExists(username, Email)) {
      return false; // User already exists
    }

    // Hash the password
    var passwordHash = HashPassword(password);

    using (var connection = new SqlConnection(connectionString)) {
      connection.Open();
      // Include CreatedAt using GETDATE() and set IsActive explicitly to 1
      var query =
          "INSERT INTO SystemUsers (Username, Email, PasswordHash, IsActive, " +
          "CreatedAt) VALUES (@Username, @Email, @PasswordHash, 1, GETDATE())";

      using (var command = new SqlCommand(query, connection)) {
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Email", Email);
        command.Parameters.AddWithValue("@PasswordHash", passwordHash);

        var result = command.ExecuteNonQuery();
        return result >
               0; // Returns true if the insert operation was successful
      }
    }
  }

  private bool UserExists(string username, string Email) {
    using (var connection = new SqlConnection(connectionString)) {
      connection.Open();
      var query = "SELECT COUNT(1) FROM SystemUsers WHERE Username = " +
                  "@Username OR Email = @Email";

      using (var command = new SqlCommand(query, connection)) {
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Email", Email);

        var result = (int)command.ExecuteScalar();
        return result > 0; // Returns true if a user with the same username or
                           // email already exists
      }
    }
  }
}
}