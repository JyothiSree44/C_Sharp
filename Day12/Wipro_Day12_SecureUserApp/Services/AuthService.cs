using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Wipro_Day12_SecureUserApp.Models;

namespace Wipro_Day12_SecureUserApp.Services
{
    public class AuthService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        private EncryptionService encryptionService = new EncryptionService();

        public void Register(string username, string password, string email)
        {
            try
            {
                if (users.ContainsKey(username))
                    throw new Exception("User already exists");

                byte[] encryptedEmail = encryptionService.Encrypt(email);

                users.Add(username, new User
                {
                    Username = username,
                    HashedPassword = HashPassword(password),
                    EncryptedEmail = Convert.ToBase64String(encryptedEmail)
                });

                LoggerService.Log("User registered: " + username);
            }
            catch (Exception ex)
            {
                LoggerService.Log("Registration error: " + ex.Message);
                throw;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                if (!users.ContainsKey(username))
                    return false;

                return users[username].HashedPassword == HashPassword(password);
            }
            catch (Exception ex)
            {
                LoggerService.Log("Login error: " + ex.Message);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
