# masterloop-amqp-example

This is an example of how to use the Masterloop API to get a AMQP queue which then can be consumed from using the AMQP Rabbit Client library

This example shows how to setup 2 consumers with each their own channel which in turn uses the AsyncEventingBasicConsumer model to receive multiple messages asynchronously.

You must set (appsettings.json) :

persistentSubscriptionKey - the name to use for the queue in Masterloop
userName
password
