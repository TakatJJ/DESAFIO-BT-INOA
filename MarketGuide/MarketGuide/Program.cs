﻿using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using MarketGuide;
using Newtonsoft.Json;

class Program
{
    
    static async Task Main(string[] args)
    {
        // Replace the API URL with the actual endpoint you want to call
        string token = "1xGjrWigkkC1RJfiz43Ewx";
        string apiUrl = $"https://brapi.dev/api/quote/{args[0]}?token={token}";
        const int Minute = 60000;
        List<string> contacts = new List<string>();
        Reader reader = new Reader();
        contacts = reader.GetContent("D:\\DESAFIOS INOA\\DESAFIO BT INOA\\MarketGuide\\MarketGuide\\Emails.txt");

        // Create an instance of HttpClient
        while (true) {
            
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send a GET request to the API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Check if the response is successful (status code 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the content of the response as a string
                        string result = await response.Content.ReadAsStringAsync();

                        APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(result);

                        UserClauses userClauses = new UserClauses(args);
                        userClauses.CheckClauses(apiResponse.Results[0].RegularMarketPrice, apiResponse.Results[0].Symbol, contacts);

                    }
                    else
                    {
                        // Handle the case where the request was not successful
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return;
                    }
                    await Task.Delay(Minute);
                }
                catch (Exception ex)
                {
                    // Handle exceptions that may occur during the request
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        
        }
    }
}