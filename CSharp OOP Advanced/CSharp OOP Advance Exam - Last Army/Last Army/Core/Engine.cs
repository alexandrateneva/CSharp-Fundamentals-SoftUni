﻿namespace Last_Army.Core
{
    using System;
    using Last_Army.Constants;
    using Last_Army.Interfaces;
    using Last_Army.Interfaces.IO;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private bool isRunning;
        private IGameController gameController;

        public Engine(IReader reader, IWriter writer, IGameController gameController)
        {
            this.isRunning = false;
            this.reader = reader;
            this.writer = writer;
            this.gameController = gameController;
        }

        public void Run()
        {
            this.isRunning = true;

            while (this.isRunning)
            {
                string input = this.reader.ReadLine();
                if (input == OutputMessages.InputTerminateString)
                {
                    this.isRunning = false;
                    continue;
                }

                try
                {
                    this.gameController.ProcessCommand(input);
                }
                catch (ArgumentException arg)
                {
                    this.writer.StoreMessage(arg.Message);
                }
            }

            this.gameController.ProduceSummury();
            this.writer.WriteLine(this.writer.StoredMessage.Trim());
        }
    }
}

