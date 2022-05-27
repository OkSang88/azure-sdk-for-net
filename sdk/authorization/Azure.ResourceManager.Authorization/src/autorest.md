# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

``` yaml

azure-arm: true
csharp: true
library-name: Authorization
namespace: Azure.ResourceManager.Identity.Authorization
# require: https://raw.githubusercontent.com/Azure/azure-rest-api-specs/a416080c85111fbe4e0a483a1b99f1126ca6e97c/specification/authorization/resource-manager/readme.md
require: https://raw.githubusercontent.com/dvbb/azure-rest-api-specs/fe96f19d9de14cc9b2a151f550a1e2ebe37771df/specification/authorization/resource-manager/readme.md
output-folder: Generated/
clear-output-folder: true
skip-csproj: true
 

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4
  Ipv6: IPv6
  Ipsec: IPsec
  SSO: Sso
  URI: Uri

# directive:
#   - from: authorization-AccessReviewCalls.json
#     where: $.definitions.AccessReviewHistoryDefinitionProperties.decisions.items
#     transform: >
#         $ = {
#             "type": "string",
#             "description": "Represents a reviewer's decision for a given review",
#             "enum": [
#               "Approve",
#               "Deny",
#               "NotReviewed",
#               "DontKnow",
#               "NotNotified"
#             ],
#             "x-ms-enum": {
#               "name": "AccessReviewResult",
#               "modelAsString": true
#             }
#           }
```