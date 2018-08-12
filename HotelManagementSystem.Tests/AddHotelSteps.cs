using FluentAssertions;
using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace HotelManagementSystem.Tests
{
    [Binding]
    public class AddHotelSteps
    {
        private static int[] _ids = new int[20];
        private static int _count = -1;
        private Hotel hotel = new Hotel();
        private Hotel addHotelResponse;
        private int ID = 0;
        private static List<Hotel> hotels = new List<Hotel>();


        [Given(@"User provided valid Id '(.*)'  and '(.*)' for hotel")]
        public void GivenUserProvidedValidIdAndForHotel(int id, string name)
        {
            _count++;
            _ids[_count] = _count+1;
            hotel.Id = id;
            hotel.Name = name;
        }

        [Given(@"User has added required details for hotel")]
        public void GivenUserHasAddedRequiredDetailsForHotel()
        {
            SetHotelBasicDetails();
        }

        [Given(@"User calls AddHotel api")]
        [When(@"User calls AddHotel api")]
        public void WhenUserCallsAddHotelApi()
        {
            hotels = HotelsApiCaller.AddHotel(hotel);
        }

        [Then(@"Hotel with name '(.*)' should be present in the response")]
        public void ThenHotelWithNameShouldBePresentInTheResponse(string name)
        {
            hotel = hotels.Find(htl => htl.Name.ToLower().Equals(name.ToLower()));
            hotel.Should().NotBeNull(string.Format("Hotel with name {0} not found in response",name));
        }

        [Given(@"User provides Id '(.*)' of hotel to be searched")]
        public void GivenUserProvidesIdOfHotelToBeSearched(int id)
        {
            ID = id;
        }

        [When(@"User calls GetHotelByID api")]
        public void WhenUserCallsGetHotelByIDApi()
        {
            hotel = HotelsApiCaller.GetHotelByID(ID);
        }

        [Then(@"The result of the search should be '(.*)'")]
        public void ThenTheResultOfTheSearchShouldBeHotel(string result)
        {
            if (hotel== null)
            {
                hotel.Should().Be(null);
            }
            else
            {
                hotel.Name.Should().Be(result);
            }
        }

        [When(@"User calls GetAllHotels api")]
        public void WhenUserCallsGetAllHotelsApi()
        {
            hotels = HotelsApiCaller.GetAllHotels();
        }

        [Then(@"The result of the call should contain all the hotels should be '(.*)'")]
        public void ThenTheResultOfTheCallShouldContainAllTheHotelsShouldBe(string result)
        {
            for(int index=0;index<=_count;index++)
            {
                if (result == "present")
                {
                    hotel = hotels.Find(htl => htl.Id.Equals(_ids[index]));
                    if (hotel == null)
                    {
                        result = "not present";
                    }
                }
                else
                {
                    hotel.Should().NotBeNull(string.Format("Hotel with id {0} not found in response", _ids[index]));
                }
            }
            if(result == "not present")
                hotel.Should().NotBeNull(string.Format("Hotel with id {0} not found in response", _ids[_count]));
        }


        private void SetHotelBasicDetails()
        {
            hotel.ImageURLs = new List<string>() { "image1", "image2" };
            hotel.LocationCode = "Location";
            hotel.Rooms = new List<Room>() { new Room() { NoOfRoomsAvailable = 10, RoomType = "delux" } };
            hotel.Address = "Address1";
            hotel.Amenities = new List<string>() { "swimming pool", "gymnasium" };
        }
    }
}
