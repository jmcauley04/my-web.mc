namespace my_web.mc.Services;

public record Skill(string Name, string Points, string Percent);
public record Language(string Name, double Percent, string Blurb);
public record Project(string Title, string Tag, string Subtitle, string Date, string Description, bool ComingSoon = true);

public class ProjectsService
{
    public Dictionary<string, string> GetNotes()
    {
        return new Dictionary<string, string>
        {
            { "Citizenship", "United States" },
            { "Location", "Douglas, GA" },
            { "Age", Math.Floor((DateTime.Today - new DateTime(1985, 12, 3)).TotalDays / 365.25).ToString("N0") }
        };
    }

    public Skill[] GetSkills()
    {
        Skill[] skills = [
            new
                (
                    "Design",
                    "scalable, maintainable, reliable, performant, secure, fit-for-purpose",
                    "80%"
                ),
            new
                (
                    "Backend",
                    "ORMs, APIs, serverless functions, container, auth/auth, key vaults, logging, testing, monitoring",
                    "85%"
                ),
            new
                (
                    "Frontend",
                    "Blazor, TailwindCSS, React, Next.js, Angular",
                    "70%"
                ),
            new
                (
                    "Automation",
                    "HMIs, PLCs, Ignition, ladder logic",
                    "70%"
                ),
            new
                (
                    "Data, Reporting, and Analytics",
                    "PowerBI, Tableau, DAX, statistics, data modeling, data warehousing, ETL, data pipelines",
                    "70%"
                )
        ];
        return skills;
    }

    public Language[] GetLanguages()
    {
        Language[] languages = [
        new (
            "C#",
            .90,
            """
                This is the first procedural language I became profecient with.  Perhaps due to this, or because Microsoft works very hard to maintain
                its competitive edge, I've found it to be a versatile and powerful choice.  It may come as a surprise, but this language was also my 
                introduction to web development; when Blazor was released, I was able to leverage my existing skills to create web applications and this
                encouraged me to explore and understand additional web technologies!
            """
          ),
          new (
            "SQL",
            .90,
            """
                This is the first language I learned in a professional setting.This was my introduction to automation and data analysis.As a dimensional
                engineer at a manufacturing facility, I was able to leverage SQL to automate data collection and analysis from pre - existing data collection
                systems in a way that none of my colleagues had been able to do before.This was a major turning point in my career as I began to see the
                power of programming and automation.
            """
          ),
          new (
            "Python",
            .90,
            """
                I had used this language in the past, but it wasn't until I began working at the largest supply chain company in the world that I began to
                use it regularly and professionally.Working as an Automation Engineer, the technologies available to me were limited, but Python was
                made availabile through a low - code integration service called Dataiku where Python was used to create custom recipes.  I have leveraged
                this experience to create custom scripts for data analysis, automation, and web scraping.
            """
          ),
          new (
            "Rust",
            .30,
            """
              I have only dabbled in this language to be familiar with it, but I have been very impressed with its performance and safety features.
              I have used it to create a simple game using Bevy more extensively, but I frequently use it to create small utilities and scripts that
              can be run on any platform without the need for a runtime.
            """
          ),
          new (
            "JavaScript",
            .90,
            """
                I never wanted to learn JavaScript.  I was a C# developer and I was happy with that and Blazor allowed me to develop in the web.  However,
                as I began to expand my web development profeciency and read about D3.js, I realized how crucial it was to understand JavaScript.I have,
                since, worked with it extensively and have come to appreciate its flexibility and power.  I now consider it one of my favorite languages.
            """
          ),
          new (
            "TypeScript",
            .70,
            """
              Whether right or wrong, I see TypeScript as a C# wrapper for JavaScript. I've primarily used this language in Angular projects, but I have
              begun to use it in React projects as well.I appreciate the type safety and compile-time checking that it provides, but I sometimes find
              it to be a bit verbose and cumbersome.I fully believe this is accentuated by my lack of experience with it.
            """
          ),
          new (
            "HTML",
            .85,
            """
              Is everyone familiar with HTML? This language strikes me as the great unifier for frontend development. I have used it in conjunction
              with Blazor, Angular, and React to create web applications and I think I know it better than the average developer.I've built custom 
              components and fought with the differences between user - input controls such as the textarea and input.I frequently find new tags and
              attributes that I try to incorporate into my projects appropriately.  I find HTML to be extremely understated and unambitious, and I
              think that's a good thing.
            """
          ),
          new (
            "CSS",
            .80,
            """
              CSS is another language where I feel I am more confident than the average developer.Around the time that css grids were becoming popular,
              I began to trade out bootstrap dependence for custom css.  Bootstrap is great, but I found it to be restrictive and opinionated.While I
              don't think custom CSS is always the best choice, I think it's important to understand how to use it effectively.I have used TailwindCSS
              in a few projects and I think it's a great tool, but I still prefer to write my own CSS for complex styling.
            """
            )
        ];
        return languages;
    }

    public Project[] GetProjects()
    {
        Project[] projects = [
            new(
                "A Pipeline Built of Brick",
                "Professional",
                "Scalability, reliability, recoverability, and observability",
                "December 2024",

                """
                As the scale of our business increases, so too must the scale and reliability of our data pipeline.  This project was to create a new data
                pipeline that could handle the increased load and provide the necessary observability to ensure that it was functioning as expected.
                """
            ),
            new(
                "A Pipeline Built of Wood",
                "Professional",
                "Rebuilding the data pipeline",
                "April 2024",

                """
                After close to a year of maintaining the straw house that is our data pipeline, I've finally obtained the necessary ingredient to make this
                a house of wood.  Using the technology we have available, this new design is robust and easily maintained.
                """
            ),
            new(
                "Building a High-Code IDE",
                "Professional",
                "... for Low-Code Platform",
                "November 2023",

                """
                When working in a big company, it can be a challenge to get a centralized tech team to address your needs.  A team within my company enables
                citizen development but only through a low-code platform which is feature-poor.  This project was to create a high-code IDE to
                integrate with the low-code platform re-enabling the value that was lost when the low-code platform was adopted.
                """
            ),
            new(
                "A Pipeline Built of Straw",
                "Professional",
                "'Whether you think you can or you think you can't, you're right'",
                "July 2023",

                """
                When everyone says a thing can't be done and then someone does it, it turns heads. This project helped me to gain the confidence 
                of my leaders and peers.What started as a project to acquire data for my own needs soon became a network - wide solution.
                """
            ),
            new(
                "Automating Airfoil Analysis",
                "Professional",
                "Intention vs Definition",
                "February 2020",

                """
                It is often tempting to complete a task and move on swiftly. However, I firmly believe that maintaining an open mind and applying critical
                thinking can yield significant value. Occasionally, by taking just a few additional steps, we can unlock significant untapped potential.
                """,
                ComingSoon: false
            ),
            new(
                "Reducing the Cost of Quality",
                "Professional",
                "Inspecting with Predictive Modeling",
                "May 2019",

                """
                If predictive modeling can meet the criteria of a good inspection, then it can be used to reduce the cost of quality by directly attacking
                non - value - add activities.This project's goal was to replace physical inspection with predictive modeling through strong correlations.
                """,
                ComingSoon: false
            ),
        ];
        return projects;
    }
}

