# Getting Started with Python Exercism

Welcome! This guide will help you get started with your Python learning journey on Exercism.

## Quick Start

1. **Clone this repository** (you've already done this!)
   
2. **Install Python dependencies**:
   ```bash
   pip install -r requirements.txt
   ```

3. **Navigate to your first exercise**:
   ```bash
   cd python/hello-world
   ```

4. **Read the instructions**:
   ```bash
   cat README.md
   ```

5. **Run the tests**:
   ```bash
   python hello_world_test.py
   ```

## How to Work on an Exercise

Each exercise follows this workflow:

### 1. Read the Instructions
Each exercise has a `README.md` file explaining:
- What the exercise is about
- What you need to implement
- Examples of expected behavior

### 2. Look at the Tests
The test file (e.g., `hello_world_test.py`) shows:
- What function you need to write
- What inputs it should accept
- What outputs it should return

### 3. Write Your Solution
Edit the solution file (e.g., `hello_world.py`) to:
- Implement the required function
- Make all tests pass

### 4. Run Tests Frequently
Use tests to guide your development:
```bash
# Run tests for current exercise
python <exercise_name>_test.py

# Or use pytest for more detailed output
python -m pytest <exercise_name>_test.py -v
```

### 5. Iterate and Improve
Once tests pass:
- Can you make the code more readable?
- Can you use Python features more effectively?
- Are there edge cases you should handle?

## Available Exercises

### 1. Hello World (Beginner)
**Location**: `python/hello-world/`
**Concepts**: Basic function definition, return values
**Time**: 5-10 minutes

A simple introduction to:
- Writing a function
- Returning a string
- Running tests

### 2. Two Fer (Beginner)
**Location**: `python/two-fer/`
**Concepts**: Default parameters, f-strings
**Time**: 10-15 minutes

Learn about:
- Function parameters
- Default parameter values
- String formatting with f-strings

## Python Learning Tips

### 1. Use the Python REPL
Experiment with code interactively:
```bash
python
>>> "Hello, World!"
'Hello, World!'
>>> f"One for {'Alice'}, one for me."
'One for Alice, one for me.'
```

### 2. Read Error Messages
Python's error messages are helpful! They tell you:
- What went wrong
- Where it happened (file and line number)
- Often suggest what to fix

### 3. Use Built-in Help
```python
help(str.format)  # Get help on string formatting
dir(str)          # See all string methods
```

### 4. Follow PEP 8
Python has style guidelines (PEP 8):
- Use 4 spaces for indentation (not tabs)
- Use `snake_case` for function names
- Add docstrings to functions
- Keep lines under 79 characters

### 5. Practice Regularly
- Do at least one exercise per day
- Review your solutions after a week
- Try solving the same problem differently

## Common Python Patterns You'll Learn

### String Formatting
```python
# Old style (avoid)
"Hello, %s!" % name

# .format() method
"Hello, {}!".format(name)

# f-strings (preferred in Python 3.6+)
f"Hello, {name}!"
```

### Default Parameters
```python
def greet(name="World"):
    return f"Hello, {name}!"

greet()           # "Hello, World!"
greet("Alice")    # "Hello, Alice!"
```

### List Comprehensions
```python
# Instead of:
squares = []
for x in range(10):
    squares.append(x**2)

# Use:
squares = [x**2 for x in range(10)]
```

## Next Steps

After completing the beginner exercises:

1. **Explore more exercises**: Visit [Exercism Python Track](https://exercism.org/tracks/python)
2. **Read other solutions**: Learn different approaches
3. **Practice concepts**: Focus on areas where you struggled
4. **Build projects**: Apply what you've learned

## Resources

- **Official Python Tutorial**: https://docs.python.org/3/tutorial/
- **Python Documentation**: https://docs.python.org/3/
- **PEP 8 Style Guide**: https://www.python.org/dev/peps/pep-0008/
- **Real Python**: https://realpython.com/
- **Python Tutor** (visualize code): http://pythontutor.com/

## Getting Help

If you're stuck:

1. **Re-read the instructions** - Make sure you understand what's required
2. **Look at the test cases** - They show exactly what's expected
3. **Check error messages** - They often point to the problem
4. **Search online** - Many Python learners have had similar questions
5. **Ask for help** - Use the Exercism community or Python forums

Happy learning! 🎓🐍
