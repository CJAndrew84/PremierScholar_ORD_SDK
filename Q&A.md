# OpenRoads SDK – Q&A

Based on Premier Scholar Masterclass: OpenRoads SDK – Unlocking Your Superpowers

---

## Q1. What is the OpenRoads SDK?

The OpenRoads SDK (Software Developer Kit) is Bentley’s development framework that allows users to build custom tools, commands, integrations, and automation directly against OpenRoads Designer and the wider Bentley ecosystem.

It provides:

- Sample projects
- Help files
- Developer guides
- API documentation
- Example tools (such as Last Mile Tool)
- ProjectWise integration examples
- Rail examples
- Civil model access
- Geometry access
- Custom UI examples

It enables organisations to create tailored solutions instead of waiting for standard product functionality.

---

## Q2. What are the two main SDK development approaches?

**Managed SDK**

Primarily uses:

- C#
- .NET

Used for:

- Commands and key-ins
- User interfaces
- Business logic
- Workflow automation
- ProjectWise integrations

This is typically the best starting point for most users.

---

**Native / Unmanaged SDK**

Primarily uses:

- C++

Used for:

- Deeper geometry access
- Advanced civil operations
- Lower-level system access
- Performance-heavy functionality

This is significantly more advanced.

---

## Q3. Why should someone explore the SDK?

The SDK helps solve problems where standard configuration is not enough.

Typical use cases include:

- Workflow automation
- Reducing repetitive manual work
- Integrating with external systems
- Improving delivery speed
- Custom reporting
- Extracting civil model data
- Restoring corrupted model data
- Enforcing standards
- Building repeatable enterprise tools

It allows teams to bridge gaps in product functionality rather than waiting for Bentley roadmap delivery.

---

## Q4. Where do you get the SDK?

The SDK is available through:

- Bentley Software Downloads (previously Bentley Developer Network)

It is **NOT** bundled with OpenRoads Designer.

You need:

- Developer entitlement
- Bentley admin access approval

After installation, SDK setup requires running provided BAT files to establish:

- Environment variables
- Paths
- Development references

This is critical before development starts.

---

## Q5. What should beginners learn first?

Before touching the SDK, beginners should focus on:

**Core fundamentals**

- C# basics
- Object-oriented programming
- Functions and methods
- Lists and collections
- Debugging
- Basic software architecture

**Recommended learning tools**

- SoloLearn
- Visual Studio Community
- SDK examples
- Bentley Documentation Assistant (AI)

Do **NOT** start by trying to build huge enterprise tools.

Start with:

- One small problem
- A clearly defined requirement
- A repeatable workflow issue

Small wins build understanding.

---

## Q6. What is object-oriented programming in simple terms?

Object-oriented programming (OOP) allows you to define your own data structures using “objects.”

For example, instead of treating corridor data as loose variables, you create a **Corridor Object** containing:

- Name
- Description
- Alignment
- Stations
- Components
- Surfaces

This makes exporting, processing, and reusing data far easier.

Think of it as creating your own civil schema outside the DGN.

---

## Q7. Why use Visual Studio instead of VS Code?

**VS Code** — better for:

- Python
- PowerShell
- HTTP
- Lightweight editing

**Visual Studio Community / Professional** — better for:

- C#
- .NET projects
- Debugging and breakpoints
- DLL compilation
- OpenRoads SDK development

Visual Studio provides the professional development environment needed for SDK work.

---

## Q8. What are breakpoints and debugging?

Breakpoints allow you to stop code while it is running and inspect:

- Variables
- Object values
- Model outputs
- Errors
- Memory usage

Instead of guessing, debugging lets you answer *“What does the model actually contain?”* by inspecting:

- Alignments
- Corridors
- Surfaces
- Components
- Event points
- Geometry models

Debugging is one of the most important skills in SDK development.

---

## Q9. Can the SDK read live data from a DGN model?

Yes. The SDK can directly access:

- Geometry models
- Alignments
- Corridors and corridor components
- Profiles
- Surfaces
- Event points
- Cross section points
- Feature definitions
- Processing stations

This allows developers to inspect and manipulate the actual civil model, and is the foundation of most custom tools.

---

## Q10. Example: What was built for Navisworks + ProjectWise?

A custom ribbon integration was built that allowed:

- Direct ProjectWise login from Navisworks
- Opening NWF/NWD files from ProjectWise
- Appending models directly from ProjectWise
- Managed references
- Metadata transfer
- Document property synchronisation

This removed the manual export/reimport process previously required, turning Navisworks into a proper managed ProjectWise workflow.

---

## Q11. Example: What was built for Event Points?

Creating event points manually is slow and painful. A custom add-on was developed to:

- Read Excel input
- Generate event points automatically

**Result:** Thousands of event points could be created in seconds instead of hours.

This is exactly where SDK value becomes obvious.

---

## Q12. Example: What was built for Cross Sections?

Generative Components nodes were created to:

- Extract cross section points
- Rebuild sections automatically
- Create static 2D cross sections

**Benefits:**

- Significantly faster output
- Better DWG workflows
- Greater drawing control
- Improved downstream deliverables

This solved limitations in standard OpenRoads section workflows.

---

## Q13. Should we use SDK or VBA or Python?

**VBA** — Avoid where possible.

- Effectively legacy
- Microsoft is moving away from VBA
- Poor long-term support

**Python** — Excellent for:

- MicroStation automation
- Scripting
- Quick tasks

*Limitation:* Python does NOT natively expose the full civil schema. You must manually reference SDK DLLs to bridge this.

**SDK (C#)** — Best for:

- Proper OpenRoads civil access
- Supported workflows
- Enterprise deployment
- Long-term maintainability

SDK is the professional route.

---

## Q14. Can Python still work with OpenRoads civil data?

Yes — but not natively.

You can:

- Reference the C# DLLs
- Import SDK libraries into Python
- Use Python to call civil functionality

However, this is not currently a formally supported Bentley workflow. It is possible, but must be handled carefully.

---

## Q15. When should you NOT build an SDK tool?

Do **NOT** build when:

- Bentley already plans to deliver it
- It is a software defect
- It is a one-off workaround
- There is no business support
- No one will maintain it
- There is no deployment strategy
- There is no documentation plan

The question is not only *“Can we build it?”*

The real question is: **“Should we build it?”**

---

## Q16. Why is deployment strategy important?

A tool that works only on one machine is not a real enterprise solution.

Proper deployment should include:

- Managed workspace deployment
- MDL folder structure
- CFG loading
- Version control
- Support ownership
- Update strategy
- Compatibility planning

Without deployment planning, good tools die quickly.

---

## Q17. Who owns custom SDK tools?

Usually the **company**.

If you build tools using:

- Company hardware
- Company licenses
- Company GitHub
- Company time

Then the intellectual property belongs to the business. This must be understood early — ownership matters.

---

## Q18. Why is GitHub important?

GitHub provides:

- Version control
- Change tracking
- Collaboration
- Code reviews
- Merge control
- Rollback capability
- Team development

Without GitHub, maintaining enterprise SDK tools becomes extremely difficult. GitHub is not optional for serious development.

---

## Q19. How should AI be used for SDK development?

AI is helpful — but dangerous without understanding.

**Best uses:**

- Accelerating development
- Writing commentary
- Helping explain code
- Generating starter structures
- Assisting debugging

**Risks:**

- Hallucinations
- Wrong APIs
- Confusion with Autodesk APIs
- Incorrect assumptions

**Rule:** Understand the basics first. AI should accelerate expertise, not replace it.

---

## Q20. Final advice for users starting with SDK?

Do not be scared of it.

- The **worst** likely outcome: you crash OpenRoads while testing — and that is recoverable.
- The **best** outcome: you solve problems nobody else can solve.

Start small. Debug often. Document everything. Do not test in production.

And always ask:

> *“Am I building a tool… or building something the business can actually support?”*

That is the real difference between scripting and engineering.
