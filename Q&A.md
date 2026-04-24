# OpenRoads SDK – Q&A

Based on Premier Scholar Masterclass: OpenRoads SDK – Unlocking Your Superpowers


---

## Q1. What is the OpenRoads SDK?

The OpenRoads SDK (Software Developer Kit) is Bentley’s development framework that allows users to build custom tools, commands, integrations, and automation directly against OpenRoads Designer and the wider Bentley ecosystem.

It provides:

Sample projects

Help files

Developer guides

API documentation

Example tools (such as Last Mile Tool)

ProjectWise integration examples

Rail examples

Civil model access

Geometry access

Custom UI examples


It enables organisations to create tailored solutions instead of waiting for standard product functionality.


---

## Q2. What are the two main SDK development approaches?

Managed SDK

This is primarily:

C#

.NET


Used for:

commands

key-ins

user interfaces

business logic

workflow automation

ProjectWise integrations


This is typically the best starting point for most users.


---

Native / Unmanaged SDK

This is primarily:

C++


Used for:

deeper geometry access

advanced civil operations

lower-level system access

performance-heavy functionality


This is significantly more advanced.


---

## Q3. Why should someone explore the SDK?

The SDK helps solve problems where standard configuration is not enough.

Typical use cases include:

workflow automation

reducing repetitive manual work

integrating with external systems

improving delivery speed

custom reporting

extracting civil model data

restoring corrupted model data

enforcing standards

building repeatable enterprise tools


It allows teams to bridge gaps in product functionality rather than waiting for Bentley roadmap delivery.


---

## Q4. Where do you get the SDK?

The SDK is available through:

Bentley Software Downloads

previously Bentley Developer Network


It is NOT bundled with OpenRoads Designer.

You need:

developer entitlement

Bentley admin access approval


After installation, SDK setup requires running provided BAT files to establish:

environment variables

paths

development references


This is critical before development starts.


---

## Q5. What should beginners learn first?

Before touching the SDK, beginners should focus on:

Core fundamentals

C# basics

object-oriented programming

functions and methods

lists and collections

debugging

basic software architecture


Recommended learning tools

SoloLearn

Visual Studio Community

SDK examples

Bentley Documentation Assistant (AI)


Do NOT start by trying to build huge enterprise tools.

Start with:

one small problem

clearly defined requirement

repeatable workflow issue


Small wins build understanding.


---

## Q6. What is object-oriented programming in simple terms?

Object-oriented programming (OOP) allows you to define your own data structures using “objects.”

For example:

Instead of treating corridor data as loose variables, you create a:

Corridor Object

Containing:

Name

Description

Alignment

Stations

Components

Surfaces


This makes exporting, processing, and reusing data far easier.

Think of it as creating your own civil schema outside the DGN.


---

## Q7. Why use Visual Studio instead of VS Code?

VS Code

Better for:

Python

PowerShell

HTTP

lightweight editing


Visual Studio Community / Professional

Better for:

C#

.NET projects

debugging

breakpoints

DLL compilation

OpenRoads SDK development


Visual Studio provides the professional development environment needed for SDK work.


---

## Q8. What are breakpoints and debugging?

Breakpoints allow you to stop code while it is running and inspect:

variables

object values

model outputs

errors

memory usage


This is how you understand:

“What does the model actually contain?”

Instead of guessing, debugging lets you inspect:

alignments

corridors

surfaces

components

event points

geometry models


Debugging is one of the most important skills in SDK development.


---

## Q9. Can the SDK read live data from a DGN model?

Yes.

The SDK can directly access:

geometry models

alignments

corridors

corridor components

profiles

surfaces

event points

cross section points

feature definitions

processing stations


This allows developers to inspect and manipulate the actual civil model.

This is the foundation of most custom tools.


---

## Q10. Example: What was built for Navisworks + ProjectWise?

A custom ribbon integration was built that allowed:

direct ProjectWise login from Navisworks

opening NWF/NWD files from ProjectWise

appending models directly from ProjectWise

managed references

metadata transfer

document property synchronisation


This removed the manual export/reimport process previously required.

It turned Navisworks into a proper managed ProjectWise workflow.


---

## Q11. Example: What was built for Event Points?

Creating event points manually is slow and painful.

A custom add-on was developed to:

read Excel input

generate event points automatically


Result:

Thousands of event points could be created in seconds instead of hours.

This is exactly where SDK value becomes obvious.


---

## Q12. Example: What was built for Cross Sections?

Generative Components nodes were created to:

extract cross section points

rebuild sections automatically

create static 2D cross sections


Benefits:

significantly faster output

better DWG workflows

greater drawing control

improved downstream deliverables


This solved limitations in standard OpenRoads section workflows.


---

## Q13. Should we use SDK or VBA or Python?

VBA

Avoid where possible.

Reasons:

effectively legacy

Microsoft is moving away from VBA

poor long-term support



---

Python

Excellent for:

MicroStation automation

scripting

quick tasks


Limitation:

Python does NOT natively expose the full civil schema.

You must manually reference SDK DLLs to bridge this.


---

SDK (C#)

Best for:

proper OpenRoads civil access

supported workflows

enterprise deployment

long-term maintainability


SDK is the professional route.


---

## Q14. Can Python still work with OpenRoads civil data?

Yes — but not natively.

You can:

reference the C# DLLs

import SDK libraries into Python

use Python to call civil functionality


However:

This is not currently a formally supported Bentley workflow.

It is possible, but must be handled carefully.


---

## Q15. When should you NOT build an SDK tool?

Do NOT build when:

Bentley already plans to deliver it

it is a software defect

it is a one-off workaround

there is no business support

no one will maintain it

there is no deployment strategy

there is no documentation plan


The question is not only:

“Can we build it?”

The real question is:

“Should we build it?”


---

## Q16. Why is deployment strategy important?

A tool that works only on one machine is not a real enterprise solution.

Proper deployment should include:

managed workspace deployment

MDL folder structure

CFG loading

version control

support ownership

update strategy

compatibility planning


Without deployment planning, good tools die quickly.


---

## Q17. Who owns custom SDK tools?

Usually:

The company.

If you build tools using:

company hardware

company licenses

company GitHub

company time


Then the intellectual property belongs to the business.

This must be understood early.

Ownership matters.


---

## Q18. Why is GitHub important?

GitHub provides:

version control

change tracking

collaboration

code reviews

merge control

rollback capability

team development


Without GitHub, maintaining enterprise SDK tools becomes extremely difficult.

GitHub is not optional for serious development.


---

## Q19. How should AI be used for SDK development?

AI is helpful — but dangerous without understanding.

Best uses:

accelerating development

writing commentary

helping explain code

generating starter structures

assisting debugging


Risks:

hallucinations

wrong APIs

confusion with Autodesk APIs

incorrect assumptions


Rule:

Understand the basics first.

AI should accelerate expertise, not replace it.


---

## Q20. Final advice for users starting with SDK?

Do not be scared of it.

The worst likely outcome is:

You crash OpenRoads while testing.

That is recoverable.

The best outcome is:

You solve problems nobody else can solve.

Start small.

Debug often.

Document everything.

Do not test in production.

And always ask:

“Am I building a tool… or building something the business can actually support?”

That is the real difference between scripting and engineering.