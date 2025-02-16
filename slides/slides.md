---
theme: default
layout: intro
hideInToc: true
mdc: true
canvasWidth: 1080

fonts:
  sans: "Poppins, Montserrat"
  serif: "Roboto Slab"
  mono: "JetBrains Mono"
---

# Mutation Testing
Rage against the machine.

---
hideInToc: true
---

# Agenda

<Toc />

---

# What is Mutation Testing?

---

# Why Mutation Testing?

---

# Introduction to Stryker


<v-clicks>

- Open-source mutation testing tool
- Runs using your existing test suite
- Supports multiple languages
  - JavaScript / TypeScript
  - C# / .NET
  - Scala
- Can integrate into CI/CD pipelines
  - Set thresholds for when to fail the build

</v-clicks>

![Stryker](./assets/stryker-man.svg){width=450 position=absolute right=5 bottom=30}

---

# What can Stryker do?

<v-clicks>

| **Mutation Type** | **Description** |
| --- | --- |
| Equality Operator Replacement | Swap `==`, `!=`, `>`, `<`, `>=`, `<=` |
| Arithmetic Operator Replacement | Swap `+`, `-`, `*`, `/`, `%` |
| Logical Operator Replacement | Swap `!`, `&&`, `\|\|`, `and`, `is`, `is not`, `or` |
| Boolean Literal Replacement | Swap `true` & `false`, replace `cond` with `!cond` |
| Assignment Operator Replacement | Swap `=`, `+=`, `-=`, `*=`, `/=`, `%=` |
| Initialization Mutators | Replace initializers like `[1, 2, 3]` with `[]` |
| Removal Mutators | Remove statements and blocks (`return`, `break`, `throw`) |

</v-clicks>
---
src: ./pages/possible-mutations.md
---
---
src: ./pages/mutation-example.md
---

---
layout: columns
---

# Configuring Stryker in your project

::left::

TypeScript

```json
{
}
```

::right::

C#

```json
{
}
``` 

::after::

<div class="text-center mt-10">

`incremental` and `baseline` both allow you to run only the tests that are affected by the changes.

</div>

---

# Live Demo

Clone the example repo

```sh
git clone TODO ADD REPO
```

TypeScript

```sh
# Install dependencies
npm install

# Run mutation testing
npm run test:mutation
```

C#

```sh
# Install dependencies
dotnet restore

# Run mutation testing
dotnet stryker
```