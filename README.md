# PremierScholar_ORD_SDK

## Presentation
**OpenRoads SDK - Unlocking your Superpower** https://github.com/CJAndrew84/PremierScholar_ORD_SDK/blob/main/OpenRoads%20SDK.pptx
https://github.com/CJAndrew84/PremierScholar_ORD_SDK/blob/main/OpenRoads%20SDK.pdf

## Demo

### Problem Statement
How to read the Civil Object Model in C# and start to build knowledge of whats possible

### Solution
Using the Project Templates provided by Bentley in the ORD SDK, create a new project. 
The template contains 3 keyins and an auto run method

For the purposes of the demonstration, I created a simple the following code

```csharp
            // Create a connection to the civil model in the active dgn
            Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit sdkCon = Bentley.CifNET.SDK.Edit.ConsensusConnectionEdit.GetActive();

            // Get the Active Geometeric Model in the DGN
            Bentley.CifNET.GeometryModel.SDK.GeometricModel geomModel = sdkCon.GetActiveGeometricModel();

            // Object Orientated C# List of Corridor Objects (built in the solution)
            List<CorridorObject> corridorObjects = new List<CorridorObject>();

            // enumerate through all the Corridor objects in the Geometric Model
            foreach (Corridor corridor in geomModel.Corridors)
            {
                // Create a new CorridorObject to store data in        
                CorridorObject corridorObject = new CorridorObject()
                {
                    // Fill out the Object Properties from data in the Civil Model
                    Name = corridor.Name,
                    Description = corridor.FeatureName,
                    AlignmentName = corridor.CorridorAlignment.Name
                };
                // Add Corridor Object to List       
                corridorObjects.Add(corridorObject);
            }
            // do soemthing with the list
```

## Useful links

### OpenRoads Designer SDK
- **SDK Help & API Reference (ORD 2025)** https://docs.bentley.com/LiveContent/web/OpenRoads%20Designer%20SDK-v2025/Help/en/topics/2935877/GUID-0D516538-1220-4FDA-B366-2A757DDAEDAC.html
- **SDK Installation & Setup** https://docs.bentley.com/LiveContent/web/OpenRoads%20Designer%20SDK%20Help-v1/en/GUID-FD0E7B04-66C7-4576-8CB7-95E8CABDB8A8.html
- **Developer Guide & Example Projects** https://bentleysystems.service-now.com/community?id=kb_article_view&sysparm_article=KB0012549
- **Civil Programming Forum (SDK questions & answers)** https://communities.bentley.com/products/programming/civil_programming/f/civil_programming_forum

### C# & .NET Framework (ORD‑relevant)
- **.NET Framework 4.8 Overview** https://learn.microsoft.com/en-gb/dotnet/framework/get-started/overview
- **.NET Framework Class Library Reference** https://learn.microsoft.com/en-gb/dotnet/framework/reference/
- **C# Language Reference** https://learn.microsoft.com/en-gb/dotnet/csharp/language-reference/
- **Object‑Oriented Programming in C#** https://learn.microsoft.com/en-gb/dotnet/csharp/fundamentals/object-oriented/

### Generative Components (GC + SDK)
- **Generative Components Documentation** https://docs.bentley.com/en/GenerativeComponents/index.php
- **Generative Components API (Add‑ins & Custom Nodes – PDF)** https://docs.bentley.com/LiveContent/web/GenerativeComponentsAPI-En_PDF-v1/en/GenerativeComponents-API.pdf
- **GC Learning Resources & Playlists** https://bentleysystems.service-now.com/community?id=kb_article_view&sysparm_article=KB0097568

### GitHub
- https://github.com/CJAndrew84/VSToolsForMicroStationCONNECTEdition
- CJAndrew84/PremierScholar_ORD_SDK
- edashbolt/generative-components: Custom Generative Components Nodes
