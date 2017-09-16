﻿namespace BashSoft.IO.Commands
{
    using BashSoft.Attributes;
    using BashSoft.Contracts;
    using BashSoft.Execptions;

    [Alias("cmp")]
    public class CompareFilesCommand : Command
    {
        [Inject]
        private IContentComparer judge = null;

        public CompareFilesCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 3)
            {
                throw new InvalidCommandException(this.Input);
            }

            string firstPath = this.Data[1];
            string secondPath = this.Data[2];
            this.judge.CompareContent(firstPath, secondPath);
        }
    }
}
