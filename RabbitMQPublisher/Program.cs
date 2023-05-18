using RabbitMQ.Client;
using System;
using System.Text;

ConnectionFactory factory = new();
factory.Uri=new("amqps://feayvied:AHFwelZWAxbfuja1ZdAaQ2zal4Y39ij0@cow.rmq2.cloudamqp.com/feayvied");
using IConnection connection
    = factory.CreateConnection();
using IModel channel= connection.CreateModel();
channel.QueueDeclare(queue: "example-queue", exclusive: false);
byte[] message=Encoding.UTF8.GetBytes("Selam");
channel.BasicPublish(exchange:"",routingKey:"example-queue",body:message);
Console.Read();

