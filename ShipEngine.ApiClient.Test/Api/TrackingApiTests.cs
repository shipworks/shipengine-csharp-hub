/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Test
{
    /// <summary>
    ///  Class for testing TrackingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TrackingApiTests
    {
        private TrackingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TrackingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TrackingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TrackingApi
            //Assert.IsInstanceOfType(typeof(TrackingApi), instance, "instance is a TrackingApi");
        }

        
        /// <summary>
        /// Test TrackingStartTracking
        /// </summary>
        [Test]
        public void TrackingStartTrackingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string carrierCode = null;
            //string trackingNumber = null;
            //instance.TrackingStartTracking(apiKey, carrierCode, trackingNumber);
            
        }
        
        /// <summary>
        /// Test TrackingStopTracking
        /// </summary>
        [Test]
        public void TrackingStopTrackingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string carrierCode = null;
            //string trackingNumber = null;
            //instance.TrackingStopTracking(apiKey, carrierCode, trackingNumber);
            
        }
        
        /// <summary>
        /// Test TrackingTrack
        /// </summary>
        [Test]
        public void TrackingTrackTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKey = null;
            //string carrierCode = null;
            //string trackingNumber = null;
            //var response = instance.TrackingTrack(apiKey, carrierCode, trackingNumber);
            //Assert.IsInstanceOf<TrackingInformation> (response, "response is TrackingInformation");
        }
        
    }

}