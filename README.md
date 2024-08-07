# C# - Get a Queue Member How-To Guide

This project serves as a guide to help you build an application with FreeClimb. View this how-to guide on [FreeClimb.com](https://docs.freeclimb.com/docs/get-queue-member#section-c). Specifically, the project will:

- Get a member of a queue

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the how-to guide

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk
   ```

2. Configure environment variables

   | ENV VARIABLE            | DESCRIPTION                                                                                                                                                                             |
   | ----------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
   | ACCOUNT_ID              | Account ID which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard                                                         |
   | API_KEY              | API key which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard                                               |

3. Provide a value for the variables `queueuId` and `callId`. More about queues can be found [here](https://docs.freeclimb.com/reference/queues-1) and more about calls can be found [here](https://docs.freeclimb.com/reference/calls-1)

## Runnning the how-to guide

1. Run the application using command:

   ```bash
   $ dotnet run
   ```

## Getting Help

If you are experiencing difficulties, [contact support](https://freeclimb.com/support).
