// See https://aka.ms/new-console-template for more information
using GoogleMapsClient;

Console.WriteLine("Hello, World!");

var client = new GoogleMapsClient.GoogleMapsClient("asdfsaghfdghfdgaasdfsadf");

var bounds = new PlaceFindBoundsResponseModel();

bounds.Northeast = new PlaceFindLatLngLiteralResponseModel();

bounds.Northeast.Lng = 10;
bounds.Northeast.Lng = 20;
bounds.Northeast.Lng = 40;
bounds.Northeast.Lng = 30;

var value = bounds.Northeast.Lng;

var locations = await client.GetPlaceAutocompletePredictionsAsync(new PlaceAutocompletePredictionAPIArgs()
{
    Input = "Ζακύνθου 35 Πάτρα"
});