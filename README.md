# Example Library

This is a sample library used for demonstrating a simple build/release pipeline using Azure DevOps.
Check out the azure-pipelines.yml file if you're interested in the example.

The pipeline is set up to execute the following scenarios:

- Commits are pushed: Build & Test only
- Tags are pushed: Build, Test and Release (push to nuget repository)
- Pull requests: Build & Test only
- Daily builds: Build & Test only

This is explained in detail in the following blog post:
https://medium.com/@therealjordanlee/azuredevops-sample-pipeline-f78367ae37d3