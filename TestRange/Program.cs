// See https://aka.ms/new-console-template for more information
using GoogleMapsClient;

Console.WriteLine("Hello, World!");

var client = new GoogleMapsClient.GoogleMapsClient("asdfsaghfdghfdgaasdfsadf");


var locations = await client.GetPlaceAutocompletePredictionsAsync(new PlaceAutocompletePredictionAPIArgs()
{
    Input = "Ζακύνθου 35 Πάτρα"
});