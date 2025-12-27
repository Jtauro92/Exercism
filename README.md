# Exercism Python Exercises

This repository contains my solutions to Python exercises from [Exercism](https://exercism.org).

## About Exercism

Exercism is a platform for learning and practicing programming through exercises and mentorship. Each exercise comes with:
- A clear problem description
- Test cases to validate your solution
- The opportunity to learn from community solutions

## Setup

1. **Install Python** (version 3.7 or higher recommended)
   ```bash
   python --version
   ```

2. **Install dependencies**
   ```bash
   pip install -r requirements.txt
   ```

## Repository Structure

Each exercise is contained in its own directory under `python/`:

```
python/
  ├── hello-world/
  │   ├── README.md          # Exercise instructions
  │   ├── hello_world.py     # Solution file
  │   └── hello_world_test.py # Test file
  ├── two-fer/
  │   ├── README.md
  │   ├── two_fer.py
  │   └── two_fer_test.py
  └── ... (more exercises)
```

## Running Tests

To run tests for a specific exercise:

```bash
cd python/hello-world
python -m pytest hello_world_test.py
```

Or using unittest:
```bash
cd python/hello-world
python hello_world_test.py
```

To run all tests in an exercise directory:
```bash
cd python/hello-world
python -m pytest
```

## Learning Path

I recommend working through exercises in this order:

1. **hello-world** - Get familiar with the basic structure
2. **two-fer** - Learn about default parameters and string formatting
3. (More exercises to be added as you progress)

## Tips for Learning

- **Read the instructions carefully** - Each exercise's README contains important details
- **Run tests frequently** - Use tests to guide your development
- **Start simple** - Get a basic solution working first, then refactor
- **Explore multiple solutions** - After solving, try different approaches
- **Use Python features** - Practice using built-in functions, list comprehensions, etc.
- **Write clean code** - Follow PEP 8 style guidelines

## Resources

- [Exercism Python Track](https://exercism.org/tracks/python)
- [Python Official Documentation](https://docs.python.org/3/)
- [PEP 8 Style Guide](https://www.python.org/dev/peps/pep-0008/)

## Progress

- [x] Hello World
- [x] Two Fer
- [ ] More exercises coming soon!

Happy coding! 🐍
