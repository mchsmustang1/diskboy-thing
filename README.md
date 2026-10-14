# Diskboy version query API

This .NET 8 minimal API checks whether a game version is supported.

## Run locally

```sh
dotnet run --project Diskboy.Api
```

The initial supported version is `0:1`. Set `DISKBOY_SUPPORTED_VERSIONS` to a
comma-separated list to support additional versions, for example:

```sh
DISKBOY_SUPPORTED_VERSIONS="0:1,0:2,1:0" dotnet run --project Diskboy.Api
```

## Query

Request `GET /headlessbox/query/v2/version?version=0:1`. Supported versions
return `This version is supported.`; an unsupported or missing version returns
`this version is outdated or has been sunsetted!`.

When deployed at `api.diskboy.net`, the full URL is
`https://api.diskboy.net/headlessbox/query/v2/version?version=0:1`.
