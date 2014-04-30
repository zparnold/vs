/*******************************************************************************
* Copyright 2009-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
* 
* Licensed under the Apache License, Version 2.0 (the "License"). You may
* not use this file except in compliance with the License. A copy of the
* License is located at
* 
* http://aws.amazon.com/apache2.0/
* 
* or in the "license" file accompanying this file. This file is
* distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
* KIND, either express or implied. See the License for the specific
* language governing permissions and limitations under the License.
*******************************************************************************/

using System;

using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace AwsSnsSample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Definitely don't press the ENTER key!");
            Console.ReadKey();

            var sns = new AmazonSimpleNotificationServiceClient();

            var sub = new SubscribeRequest();
            sub.Protocol = "SMS";
            sub.Endpoint = "1-973-459-9920";
            sub.Endpoint = "1-843-259-9433";
            sub.Endpoint = "1-978-408-9992";
            sub.TopicArn = "arn:aws:sns:us-east-1:946008981535:Crazy-ex-girlfriend";
            
            Console.WriteLine("Count:");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    
                    Console.Write("\r{0}   ", i + 1);
                    sns.Subscribe(sub);
                    
                    /*
                    var pub = new PublishRequest();
                    pub.Message = "Hey Verrelli";
                    pub.TopicArn = "arn:aws:sns:us-east-1:946008981535:SigEp-Messages";
                    sns.Publish(pub);
                     * */
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);


                }
                //System.Threading.Thread.Sleep(5000);
            }
            Console.WriteLine("");
            Console.WriteLine("Messages Sent");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
            
            
        }
    }
}