﻿using CommandLine;

namespace dotnet_jaguarportal
{
    internal class Options
    {

        [Option("submit", Required = false, Group = "action", HelpText = "Perform action submit.")]
        public bool Submit { get; set; }

        [Option("prepare", Required = false, Group = "action", HelpText = "Perform action prepare.")]
        public bool Prepare { get; set; }

        [Option('p', "projectKey", Required = true, HelpText = "Set Project Key from your project in JaguarPortal.")]
        public string? ProjectKey { get; set; }

        [Option('n', "projectName", Required = true, HelpText = "Set Project Name from your project in JaguarPortal.")]
        public string? ProjectName { get; set; }

        [Option('k', "apiKey", Required = true, HelpText = "Set ApiKey from your account in JaguarPortal.")]
        public string? ApiKey { get; set; }

        [Option('h', "hostUrl", Required = true, HelpText = "Set Host URL from your published JaguarPortal.")]
        public string? HostUrl { get; set; }

        [Option("prKey", Required = false, HelpText = "Set Pull Request Key.")]
        public string? PullRequestKey { get; set; }

        [Option("prBranch", Required = false, HelpText = "Set Pull Request Branch.")]
        public string? PullRequestBranch { get; set; }

        [Option("prBase", Required = false, HelpText = "Set Pull Request Base from github.")]
        public string? PullRequestBase { get; set; }

        [Option("prRepo", Required = false, HelpText = "Set Pull Request Repository.")]
        public string? PullRequestRepository { get; set; }

        [Option("prProvider", Required = false, HelpText = "Set Pull Request Provider (default: github).", Default = "github")]
        public string? PullRequestProvider { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Set verbose log enable.")]
        public bool Verbose { get; set; }

    }

}
