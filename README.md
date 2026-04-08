# Hero Engine

## Annotations
I'm adding default values for everything so we can avoid some errors quickly as an object, but in the main program  those issues should be controlled.

### Heroes
We stablish each hero has a `name`, a `level` and `health`.
Even if it's not really necessary, we will limit the `name` options so it has to have more than 3 characters.

Defaults values:
- `name`: player
- `level`: 1
- `health`: 100

Also, there are 3 types of heroes: `Warrior`, `Mage` and `Rogue`

#### Warrior
Warriors must have an `armor` and a `war cry`.
The `war cry` will need at least 8 characters for it to be set.

Defaults values:
- `armor`: 2
- `warCry`: Default war cry

#### Mage
Mages have `mana` and an `ark level`.

Default values:
- `mana`: 50
- `arkLevel`: 1

#### Rogue
Rogues have a `harm multiplier` and a number of `hidden blades`.

Default values: 
- `harmMultiplier`: 1
- `hiddenBlades`: 0