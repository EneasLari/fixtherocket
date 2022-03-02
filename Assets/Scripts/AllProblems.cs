using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using static MathematicalProblems;

public class AllProblems 
{
    static string problem = "";
    static string[] answers;
    static int correctindex = 0;
    public static void AddTaksiEnotita(bool canadd, string togglename)
    {
        if (canadd && togglename.Equals("taksi3enotita1"))
        {
            //Μαθηματικά Προβλήματα Γ Δημοτικού Κεφ.1 Αριθμοί μέχρι το 1000
            problem = "Τριψήφιοι λέγονται οι αριθμοί που έχουν ... ψηφία";
            answers = new string[] { "τρία", "τέσσερα" };
            correctindex = 0;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Οι τριψήφιοι αριθμοί μπορούν να έχουν Εκατοντάδες (Ε), ... (Δ) και Μονάδες (Μ)";
            correctindex = 0;
            answers = new string[] { "Δεκάδες", "Χιλιάδες" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Όταν θέλουμε να γράψουμε έναν τριψήφιο αριθμό γράφουμε πρώτα το ψηφίο των Εκατοντάδων (Ε), μετά των Δεκάδων (Δ) και μετά των .... (Μ)";
            correctindex = 1;
            answers = new string[] { "Δεκάδων (Δ)", "Μονάδων (Μ)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Για να συγκρίνουμε δύο τριψήφιους αριθμούς συγκρίνουμε πρώτα τις Εκατοντάδες (Ε). Αν είναι ίσες, συγκρίνουμε τις Δεκάδες (Δ). Αν και αυτές είναι ίσες τις συγκρίνουμε τις Μονάδες (Μ)";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 356 είναι";
            answers = new string[] { "διψήφιος", "τριψήφιος" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "O αριθμός 356 έχει 3 Εκατοντάδες (Ε), 5 Δεκάδες (Δ) και 6 (Μονάδες)";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 126 έχει 2 Μονάδες (Μ)";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "185 > 365 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια εκατοντάδα είναι 100 μονάδες ή ... φορές απο 1";
            answers = new string[] { "10", "100" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια Δεκάδα είναι ... μονάδες ή ... φορές απο 1 ";
            correctindex = 0;
            answers = new string[] { "10", "100" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "100 μονάδες είναι μια εκατοντάδα";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια Εκατοντάδα έχει ... δεκάδες ή ... φορές απο 10";
            correctindex = 1;
            answers = new string[] { "5", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 20 έχει δύο";
            correctindex = 1;
            answers = new string[] { "Εκατοντάδες (Ε)", "Δεκάδες (Δ)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 100 έχει ... μονάδες ή ... φορές απο 1";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 100 έχει ... δεκάδες ή ... φορές απο 10";
            answers = new string[] { "10", "100" };
            correctindex = 0;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 100 έχει ... Εκατοντάδα/ες ή ... φορά/ές απο 100 ";
            correctindex = 1;
            answers = new string[] { "100", "1" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 100 είναι μια Εκατοντάδα. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 100 είναι 10 Δεκάδες ή δέκα φορές από 10. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "10 μονάδες είναι μια δεκάδα. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια εκατοντάδα είναι ίση με 10 δεκάδες";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 9 Εκατοντάδες (Ε), 6 Μονάδες (Μ) και 7 Δεκάδες (Δ). Ποιός αριθμός είναι;";
            correctindex = 1;
            answers = new string[] { "769", "967" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ποια είναι η αξία του 5 στον αριθμό 568";
            answers = new string[] { "Δεκάδες (Δ)", "Εκατοντάδες (Ε)" };
            correctindex = 1;
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "540<450  Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 2 Εκατοντάδες και 9 Μονάδες. Ποιός αριθμός είναι;";
            correctindex = 1;
            answers = new string[] { "290", "209" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 2 Εκατοντάδες (Ε) και 3 Μονάδες (Μ). Ποιός αριθμός είναι;";
            correctindex = 1;
            answers = new string[] { "203", "230" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πόσες Εκατοντάδες έχει ο αριθμός 308;";
            correctindex = 0;
            answers = new string[] { "3", "8" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Συνέχισε το αριθμητικό μοτίβο 100-200-300";
            correctindex = 1;
            answers = new string[] { "4000", "400" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "200>196 Σωστό ή Λάθος";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πόσο κάνει 500+2+30";
            correctindex = 0;
            answers = new string[] { "532", "523" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 306 διαβάζεται ως";
            correctindex = 1;
            answers = new string[] { "τριακόσια δέκα έξι", "τριακόσια έξι" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "200+50+10>100+100+100 Σωστό ή Λάθος";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 115 αναλύεται σε άθροισμα ως";
            correctindex = 0;
            answers = new string[] { "100+10+5", "100+5+5" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Έχω τον αριθμό 985.Ποιός είναι ο προηγούμενος";
            correctindex = 0;
            answers = new string[] { "984", "986" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
        if (canadd && togglename.Equals("taksi3enotita2"))
        {
            //Μαθηματικά Προβλήματα Γ Δημοτικού Κεφ.14 Αριθμοί μέχρι το 3.000

            problem = "Τετραψήφιοι λέγονται οι αριθμοί που έχουν ... ψηφία";
            correctindex = 1;
            answers = new string[] { "τρία", "τέσσερα" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Για να διαβάσω έναν τετραψήφιο αριθμό, χωρίζω απο το τέλος του τρία ψηφία με τελεία";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Όταν θέλουμε να γράψουμε έναν τετραψήφιο αριθμό, γράφουμε το ψηφίο των ... (Χ), μετά των Εκατοντάδων (Ε) μετά των Δεκάδων (Δ) και τέλος των Μονάδων (Μ)";
            correctindex = 1;
            answers = new string[] { "Δεκάδων", "Χιλιάδων" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Για να συγκρίνουμε τετραψήφιους αριθμούς, συγκρίνουμε πρώτα τις Χιλιάδες (Χ).Αν είναι ίσες, συγκρίνουμε τις Εκατοντάδες (Ε). Αν και αυτές είναι ίσες τις ... (Δ) και τέλος τις Μονάδες (Μ)";
            correctindex = 0;
            answers = new string[] { "Δεκάδες", "Μονάδες" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 1.456 είναι";
            correctindex = 0;
            answers = new string[] { "τετραψήφιος", "τριψήφιος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός επτά χιλιάδες διακόσια ογδόντα πέντε γράφεται ως";
            correctindex = 0;
            answers = new string[] { "7.285", "7000285" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 2.985 έχει 2";
            correctindex = 0;
            answers = new string[] { "Χιλιάδες (Χ)", "Εκατοντάδες (Ε)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.196<2.189 Σωστό ή Λάθος";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μία χιλιάδα είναι ίση με ... μονάδες ή ... φορές το 1";
            correctindex = 1;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μία χιλιάδα είναι ίση με ... δεκάδες ή ... φορές το 10";
            correctindex = 0;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια χιλιάδα είναι ίση με ... εκατοντάδες ή ... φορές το 100";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Σε έναν αριθμό το ίδιο ψηφίο έχει διαφορετική αξία αναλογα με τη θέση του";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 3.000 έχει 3";
            correctindex = 1;
            answers = new string[] { "εκατοντάδες", "χιλιάδες" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 1.000 είναι ίσος με ... εκατοντάδες ή ... φορές απο 100";
            correctindex = 1;
            answers = new string[] { "100", "10" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 1.000 είναι μια χιλιάδα. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 1.000 είναι 10 εκατοιντάδες ή 10 φορές το 100. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "1.635>1.653 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Μια χιλιάδα είναι ίση με 100 δεκάδες";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 2 Χιλιάδες (Χ), 8 Εκατοντάδες (Ε), 7 Δεκάδες (Δ) και 6 Μονάδες (Μ). Ποιός αριθμός είναι;";
            correctindex = 1;
            answers = new string[] { "2.786", "2.876" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ποιά είναι η αξία του 7 στον αριθμό 1.785";
            correctindex = 1;
            answers = new string[] { "Δεκάδες (Δ)", "Εκατοντάδες (Ε)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.879<2.789 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 2 Χιλιάδες (Χ) και 3 Μονάδες (Μ). Ποιός αριθμός είναι;";
            correctindex = 0;
            answers = new string[] { "2.003", "2.030" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 2.000 πόσες χιλιάδες έχει;";
            correctindex = 0;
            answers = new string[] { "2", "3" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Συνέχισε το αριθμιτικό μοτίβο 1.000-2.000-...";
            correctindex = 1;
            answers = new string[] { "300", "3.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.657>2.299 Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πόσο κάνει 2.000+200+30+5;";
            correctindex = 0;
            answers = new string[] { "2.235", "20.235" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 2.569 διαβάζεται ως";
            correctindex = 0;
            answers = new string[] { "δύο χιλιάδες πεντακόσια εξήντα", "διακόσιες πενήντα έξι χιλιάδες" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "2.000+100+30+5 > 2.000+200+80+9";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 1.965 γράφεται σαν άθροισμα ως";
            correctindex = 1;
            answers = new string[] { "1.000+900+5+6", "1.000+900+50+6" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Έχω τον αριθμό 3.000.Ποιός είναι ο προηγούμενος;";
            correctindex = 0;
            answers = new string[] { "2.999", "2.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
        if (canadd && togglename.Equals("taksi3enotita3")) 
        {
            //Μαθηματικά Προβλήματα Γ Δημοτικού Κεφ.40 Αριθμοί μέχρι το 7.000

            problem = "Οι τετραψήφιοι αριθμοί έχουν ... ψηφία";
            correctindex = 1;
            answers = new string[] { "τρία", "τέσσερα" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Για να διαβάσουμε έναν τετραψήφιο αριθμό, μετράμε απο το τέλος του τρία ψηφία και βάζουμε τελεία";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Όταν θέλουμε να γράψουμε έναν τετραψήφιο αριθμό, γράφουμε πρώτα το ψηφίο των Χιλιάδων (Χ), μετά των ... (Ε), μετά των Δεκάδων (Δ) και τέλος των Μονάδων (Μ)";
            correctindex = 0;
            answers = new string[] { "Εκατομμυρίων", "Εκατοντάδων" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Για να συγκρίνουμε τετραψήφιους αριθμούς, συγκρίνουμε αντίστοιχα τα ψηφία τους, ξεκινώντας απο τις Χιλιάδες (Χ) και συνεχίζοντας, αν χρειαστεί με τις Εκατοντάδες (Ε), Δεκάδες (Δ) και τις Μονάδες (Μ)";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 4.956 είναι";
            correctindex = 1;
            answers = new string[] { "τριψήφιος", "τετραψήφιος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός επτά χιλιάδες διακόσια ογδόντα πέντε γράφεται ως";
            correctindex = 1;
            answers = new string[] { "7000285", "7.285" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 5.985 έχει 9";
            correctindex = 0;
            answers = new string[] { "Χιλιάδες (Χ)", "Εκατοντάδες (Ε)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.196>6.189 Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πέντε χιλιάδες είναι ... μονάδες ή ...  φορές απο 1";
            correctindex = 1;
            answers = new string[] { "500", "5.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Έξι χιλιάδες είναι ... δεκάδες ή ... φόρές απο 10";
            correctindex = 0;
            answers = new string[] { "600", "6.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Επτά χιλιάδες είναι ... εκατοντάδες ή ... φορές απο 100";
            correctindex = 0;
            answers = new string[] { "70", "7.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Σε έναν αριθμό το ίδιο ψηφίο έχει διαφορετική αξία ανάλογα με τη θέση του";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 7.000 έχει εκατοντάδες ή ... φορές απο 100";
            correctindex = 0;
            answers = new string[] { "70", "700" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 6.000 έχει ... μονάδες ή ... φορές απο 1";
            correctindex = 0;
            answers = new string[] { "6.000", "600" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 5.000 έχει δεκάδες ή ... φορές απο 10";
            correctindex = 1;
            answers = new string[] { "50", "500" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 8.021 έχει 8";
            correctindex = 1;
            answers = new string[] { "Εκατοντάδες (Ε)", "Χιλιάδες" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 5.000 έχει 5 χιλιάδες. Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Το 3.000 είναι 3 φορές απο 10 εκατοντάδες ή 3 φορές απο ...";
            correctindex = 1;
            answers = new string[] { "100", "1.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.785>6.816 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "5 χιλιάδες είναι ίσες με 500 εκατοντάδες";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 6 Χιλιάδες (Χ), 5 Εκατοντάδες (Ε), 9 Δεκάδες (Δ) και 3 Μονάδες (Μ).Ποιός αριθμός είναι;";
            correctindex = 0;
            answers = new string[] { "6.593", "6,953" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ποιά η αξία του 5 στον αριθμό 5.593";
            correctindex = 1;
            answers = new string[] { "Χιλιάδες (Χ)", "Εκατοντάδες (Ε)" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "4.975>4.957 Σωστό ή Λάθος;";
            correctindex = 0;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ένας αριθμός έχει 5 χιλιάδες και 3 δεκάδες. Ποιός αριθμός είναι;";
            correctindex = 1;
            answers = new string[] { "5.003", "5.030" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο αριθμός 7.000 πόσες χιλιάδες έχει;";
            correctindex = 1;
            answers = new string[] { "8", "7" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Συνέχισε το αριθμητικό μοτίβο 4.500-5.000-5.500-...";
            correctindex = 1;
            answers = new string[] { "6.500", "6.000" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "6.719>6.781 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Πόσο κάνει 5.000+100+6+50";
            correctindex = 0;
            answers = new string[] { "5.156", "5.165" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Ο άριθμος 6.572 διαβάζεται ως";
            correctindex = 1;
            answers = new string[] { "εξακόσιες χιλιάδες πεντακόσια εβδομήντα δύο", "έξι χιλιάδες πεντακόσια εβδομήντα δύο" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "4.000+10+500+6 > 4.000+3+800+2 Σωστό ή Λάθος;";
            correctindex = 1;
            answers = new string[] { "Σωστό", "Λάθος" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "ΤΟ 5.490 γράφεται σαν άθροισμα ως";
            correctindex = 0;
            answers = new string[] { "5.000+400+90", "5.000+40+0+90" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));

            problem = "Έχω τον αριθμό 6.999. Ποιός είναι ο επόμενος;";
            correctindex = 0;
            answers = new string[] { "7.000", "6.998" };
            MathProblems.Add(new MathProblem(problem, answers, correctindex));
        }
    }
    ///TODO:prepei na ksexoriso se enotites ta problimata oste na ginontai bind me ta toggles
    public static void SetAllProblems()
    {      
 
        //Μαθηματικά Προβλήματα Γ Δημοτικού Κεφ.53 Αριθμοί μέχρι το 10.000

        problem = "Οι πενταψήφιοι έχουν ... ψηφία";
        correctindex = 0;
        answers = new string[] { "πέντε", "τέσσερα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να διαβάσουμε έναν τετραψήφιο αριθμό, μετράμε απο το τέλςο του ... ψηφία και χωρίζουμε με τελεία";
        correctindex = 0;
        answers = new string[] { "τρία", "δύο" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Στους τετραψήφιους αριθμούς το 1ο ψηφίο απο το τέλος είναι των Μονάδων (Μ), το 2ο των Δεκάδων (Δ), το 3ο των Εκατοντάδων (Ε) και το 4ο των ...";
        correctindex = 1;
        answers = new string[] { "Εκατομμυρίων", "Χιλιάδων" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να συγκρίνουμε τετραψήφιους αριθμούς, συγκρίνουμε αντίστοιχα τα ψηφία τους, ξεκινώντας απο τις Μονάδες και συνεχίζοντας, αν χρειαστεί, με τις Δεκάδες, τις Εκατοντάδες και τις Χιλιάδες";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 είναι";
        correctindex = 0;
        answers = new string[] { "πενταψήφιος", "τετραψήφιος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός επτά χιλιάδες τριακόσια ενενήντα πέντε γράφεται ως";
        correctindex = 1;
        answers = new string[] { "7.035", "7.395" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 8.495 έχει 8";
        correctindex = 1;
        answers = new string[] { "Εκατοντάδες (Ε)", "Χιλιάδες (Χ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Εννιά χιλιάδες είναι ίσες με ... μονάδες ή ... φορές απο 1";
        correctindex = 1;
        answers = new string[] { "900", "9.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Οκτώ χιλιάδες είναι ίσες με ... δεκάδες ή ... φορές απο 10";
        correctindex = 0;
        answers = new string[] { "800", "80" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Επτά χιλιάδες είναι ίσες με ... εκατοντάδες ή ... φορές απο 100";
        correctindex = 0;
        answers = new string[] { "70", "700" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 είναι ...";
        correctindex = 0;
        answers = new string[] { "πενταψήφιος", "τετραψήφιος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 8.000 είναι ίσος με ... μονάδες ή ... φορές απο 1";
        correctindex = 1;
        answers = new string[] { "800", "8.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 9.000 είναι ίσος με ... δεκάδες ή ... φορές απο 10";
        correctindex = 0;
        answers = new string[] { "9.000", "900" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 10.000 είναι ίσος με ... εκατοντάδες ή ... φορές απο 100";
        correctindex = 0;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 10.000 είναι ίσος με ... χιλιάδες ή ... φορές απο 1.000";
        correctindex = 1;
        answers = new string[] { "1.000", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 7.988 έχει 7";
        correctindex = 0;
        answers = new string[] { "Χιλιάδες (Χ)", "Εκατοντάδες (Ε)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 9.000 είναι 9 φορές απο 1.000 μονάδες ή 9 φορές απο 1.000";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "8.789<8.987 Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Εννιά χιλιάδες είναι ίσες με 90 δεκάδες";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ένας αριθμός έχει 8 Χιλιάδες (Χ), 7 Δεκάδες, 9 Εκατοντάδες και 2 Μονάδες (Μ). Ποιός αριθμός είναι;";
        correctindex = 1;
        answers = new string[] { "8.792", "8.972" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η αξία του 8 στον αριθμό 9.080;";
        correctindex = 0;
        answers = new string[] { "Δεκάδες (Δ)", "Μονάδες (Μ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "9.875>9.789 Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ένας αριθμός έχει 9 Χιλιάδες (Χ), 7 Εκατοντάδες (Ε) και 5 Μονάδες (Μ). Ποιός αριθμός είναι";
        correctindex = 0;
        answers = new string[] { "9.075", "9.705" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 πόσες χιλιάδες έχει;";
        correctindex = 1;
        answers = new string[] { "0", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 8.540-8.560-...";
        correctindex = 1;
        answers = new string[] { "8.570", "8.580" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιός είναι τετραψήφιος αριθμός που μπορεί να φτιαχτεί με τα ψηφία 8-6-9-3 και είναι πιο κοντά στο 9.000;";
        correctindex = 0;
        answers = new string[] { "8.863", "8.836" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τους αριθμούς α.5.986  β.7.906 γ.5.896 δ.7.856 . Ποιά η σωστή σειρά από τον μεγαλύτερο στον μικρότερο;";
        correctindex = 0;
        answers = new string[] { "δ-β-γ-α", "β-δ-α-γ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 7.896 διαβάζεται ως";
        correctindex = 1;
        answers = new string[] { "επτά χιλιάδες οκτακόσια εξήντα εννιά", "επτά χιλιάδες οκτακόσια ενενήντα έξι" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7.000+900+5+30 > 700+30+8.000+2 Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 7.965-8.970-....";
        correctindex = 0;
        answers = new string[] { "7.975", "7.980" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 8.000. Ποιός είναι ο προηγούμενος;";
        correctindex = 1;
        answers = new string[] { "7.000", "7.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));



        //Μαθηματικά Προβλήματα Δ Δημοτικού Κεφ.2 Αριθμοί μέχρι το 10.000

        problem = "Τετραψήφιοι λέγονται οι αριθμοί που έχουν ... ψηφία";
        correctindex = 1;
        answers = new string[] { "τρία", "τέσσερα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να διαβάσω έναν τετραψήφιο αριθμό, χωρίζω απο το τέλος του τρία ψηφία με τελεία";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν θέλουμε να γράψουμε έναν τετραψήφιο αριθμό, γράφουμε πρώτα το ψηφίο των ... (Χ), μετά των Εκατοντάδων (Ε), μετά των Δεκάδων (Δ) και τέλος των Μονάδων (Μ) ";
        correctindex = 0;
        answers = new string[] { "Χιλιάδων", "Δεκάδων" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να συγκρίνουμε τετραψήφιους αριθμούς, συγκρίνουμε πρώτα τις Χιλιάδες (Χ). Αν είναι ίσες, συγκρίνουμε τις Εκατοντάδες (Ε). Αν και αυτές είναι ίσες τις ... και τέλος τις Μονάδες (Μ)";
        correctindex = 0;
        answers = new string[] { "Δεκάδες (Δ)", "Μονάδες (Μ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 είναι τετραψήφιος";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ό αριθμός εννιά χιλιάδες εκατόν ογδόντα πέντε γράφεται ως";
        correctindex = 1;
        answers = new string[] { "9000185", "9185" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 6.780 έχει ... Εκατοντάδες (Ε)";
        correctindex = 0;
        answers = new string[] { "6", "7" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "6.991>6.899 Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Μια χιλιάδα είναι ... μονάδες ή ... φορές απο 1";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Μια χιλιάδα είναι ... δεκάδες ή ... φορές απο 10";
        correctindex = 0;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Μια χιλιάδα είναι ... εκατοντάδες ή ... φορές απο 100";
        correctindex = 0;
        answers = new string[] { "10", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ένας αριθμός μπορεί να αναλυθεί σε άθροισμα με διαφορετικούς τρόπους ";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 5.000 έχει ... μονάδες ή ... φορές από 1";
        correctindex = 1;
        answers = new string[] { "500", "5.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 8.000 έχει ... δεκάδες ή ... φορές απο 10";
        correctindex = 0;
        answers = new string[] { "800", "80" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 έχει ... εκατοντάδες ή ... φορές απο 100";
        correctindex = 1;
        answers = new string[] { "1.000", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7.000+100 = 7.000+80+20 Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός οκτώ χιλιάδες εννιακόσια πέντε γράφεται ως";
        correctindex = 0;
        answers = new string[] { "8.905", "8905" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η αξία του 2 στους αριθμούς 2.055 - 7.260 αντίστοιχα;";
        correctindex = 1;
        answers = new string[] { "Εκατοντάδες (Ε) - Χιλιάδες (Χ)", "Χιλιάδες (Χ) - Εκατοντάδες (Ε)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έξι χιλιάδες είναι ίσες με 600 εκατοντάδες ή 600 φορές απο 100";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 9.785 έχει ... χιλιάδες (ΜΧ)";
        correctindex = 0;
        answers = new string[] { "9", "7" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Επιλέγω τις σωστές γραφές του 4.022 α.4.000+20+2 β.4.000+200+2 γ.3.000+1.000+22 δ.40+22";
        correctindex = 1;
        answers = new string[] { "α-β-δ", "α-γ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 7.000.Ποιός είναι ο προηγούμενος;";
        correctindex = 0;
        answers = new string[] { "6.999", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το διπλάσιο του 2.500 είναι";
        correctindex = 0;
        answers = new string[] { "5.000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 5.080-5.090-...";
        correctindex = 1;
        answers = new string[] { "6.000", "5.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τους αριθμούς α.2.010 β.1.009 γ.2.090 δ.1.000 Ποιά η σωστή σειρά απο τον μικρότερο στον μεγαλύτερο;";
        correctindex = 0;
        answers = new string[] { "δ-β-α-γ", "δ-β-γ-α" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο μεγαλύτερος τετραψήφιος που μπορεί να φτιαχτεί με τα ψηφία 6-9-5-8 είναι το 9.856;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000+2.000+50 < 3.000+50";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 4 έχει μεγαλύτερη αξία;";
        correctindex = 0;
        answers = new string[] { "49.897", "54.697" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ένας αριθμός έχει 7 Χιλιάδες (Χ), 6 Δεκάδες (Δ) και 5 Μονάδες (Μ).Ποιός είναι;";
        correctindex = 1;
        answers = new string[] { "7.650", "7.065" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός πέντε χιλιάδες εξήντα γράφεται ως";
        correctindex = 0;
        answers = new string[] { "5060", "500060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τν αριθμό 5.999.Ποιός είναι ο επόμενος;";
        correctindex = 1;
        answers = new string[] { "5.1000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 7.051 διαβάζεται ως";
        correctindex = 1;
        answers = new string[] { "επτά και πενήντα ένα", "επτά χιλιάδες πενήντα ένα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //Μαθηματικά Προβλήματα Δ Δημοτικού Κεφ.3-4 Αριθμοί μέχρι το 20.000

        problem = "Πενταψήφιοι ονομάζονται οι αριθμοί που έχουν ... ψηφία";
        correctindex = 0;
        answers = new string[] { "πέντε", "τέσσερα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Οι πενταψήφιοι αριθμοί μπορούν να έχουν Δεκάδες Χιλιάδες (ΔΧ), Μονάδες Χιλιάδες (ΜΧ), Εκατοντάδες (Ε), Δεκάδες (Δ) και Μονάδες (Μ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν θέλουμε να γράψουμε έναν πενταψήφιο αριθμό, γράφουμε πρώτα το ψηφίο των Δεκάδων Χιλιάδων (ΔΧ), μετά των ..., μετά των Εκατοντάδων (Ε), μετά των Δεκάδων (Δ) και μετά των Μονάδων (Μ)";
        correctindex = 1;
        answers = new string[] { "Δεκάδων Χίλιάδων", "Μονάδων Χιλιάδων" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δέκα μονάδες μια τάξης (π.χ. δέκα εκατοντάδες) συμπληρώνουν μια μονάδα της επόμενης τάξης (π.χ. 1 μονάδα χιλιάδων)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 16.578 είναι";
        correctindex = 0;
        answers = new string[] { "πενταψήφιος", "τετραψήφιος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 15.789 έχει 5";
        correctindex = 1;
        answers = new string[] { "Δεκάδες Χιλιάδες (ΔΧ)", "Μονάδες Χιλιάδες (ΜΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός δέκα πέντε χιλιάδες πεντακόσια πενήντα γράφεται ως";
        correctindex = 0;
        answers = new string[] { "15.550", "1550050" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 μονάδες χιλιάδες συμπληρώνουν 1 δεκάδα χιλιάδων";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Η ανάλυση ενός αριθμού μέσω της αξίας του κάθε ψηφίου λέγεται";
        correctindex = 1;
        answers = new string[] { "ανάλυση του αριθμού σε άθροισμα", "δεκαδικό ανάπτυγμα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Μια χιλιάδα είναι ίση με 100 δεκάδες ή 100 φορές απο 10";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να διαβάσουμε ένα πενταψήφιο αριθμό, μετράμε από το τέλος του τρία ψηφία και χωρίζουμε με τελεία";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε έναν αριθμό το ίδιο ψηφίο έχει ίδια αξία ανεξάρτητα από τη θέση του";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 2x10.000+3x1.000+7x100+5x10+2x1 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "23.752", "25.372" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 εκατοντάδες ή 100 φορές από 100, είναι ίσες με ... χιλιάδες/α";
        correctindex = 0;
        answers = new string[] { "10", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Η σωστή γραφή του αριθμού δεκατέσσερις χιλιάδες ... είναι 14.030";
        correctindex = 0;
        answers = new string[] { "τριάντα", "τρία" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 4 έχει μεγαλύτερη αξία;";
        correctindex = 1;
        answers = new string[] { "18.462", "14.896" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 15.678 έχει 1";
        correctindex = 0;
        answers = new string[] { "Δεκάδα Χιλιάδα (ΔΧ)", "Χιλιάδα (Χ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Μια Χιλιάδα είναι ... μονάδες";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συμπλήρωσε το δεκαδικό ανάπτυγμα 1x10.000+2x1.000+4x...+2x10+3x1";
        correctindex = 0;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 18.567. Αν προσθέσω μια χιλιάδα ποιός αριθμός προκύπτει;";
        correctindex = 1;
        answers = new string[] { "28.567", "19.567" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 4.080-4.090-...";
        correctindex = 1;
        answers = new string[] { "5.000", "4.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 1x10.000+2x1.000+4x100+2x1 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "12.402", "1.242" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 11.900. Ποιός είναι ο προηγούμενος;";
        correctindex = 0;
        answers = new string[] { "11.899", "10.899" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 1 στον αριθμό 16.750 είναι";
        correctindex = 1;
        answers = new string[] { "Χιλιάδες (Χ)", "Δεκάδες Χιλιάδες (ΔΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 17.508 γράφεται ως άθροισμα";
        correctindex = 1;
        answers = new string[] { "10.000+7.000+5+0+8", "10.000+7.000+500+8" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 5 έχει μεγαλύτερη αξία;";
        correctindex = 0;
        answers = new string[] { "5.980", "11.580" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το διπλάσιο του αριθμού 3.600 είναι";
        correctindex = 1;
        answers = new string[] { "61200", "7.200" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η σωστή σειρά των αριθμών α.12.598  β.12.805 γ.12.085 δ.12.850 από τον μεγαλύτερο στον μικρότερο;";
        correctindex = 1;
        answers = new string[] { "γ-α-β-δ", "δ-β-α-γ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η σωστή σειρά των αριθμών α.12.598  β.12.805 γ.12.085 δ.12.850 από τον μεγαλύτερο στον μικρότερο;";
        correctindex = 1;
        answers = new string[] { "γ-α-β-δ", "δ-β-α-γ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "9.000+... = 10.000 Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "1.000", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "2 x ....=12.000 Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "6.000", "4.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10.000 : 2 = ...   Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "5.000", "500" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "19.000 - ... = 9.000 Συμπλήρωσε την ισότητα";
        correctindex = 1;
        answers = new string[] { "10.000", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //Μαθηματικά Προβλήματα Δ Δημοτικού Κεφ.36 Αριθμοί μέχρι το 100.000

        problem = "Πενταψήφιοι ονομάζονται οι αριθμοί που έχουν ... ψηφία";
        correctindex = 0;
        answers = new string[] { "έξι", "πέντε" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Οι εξαψήφιοι αριθμοί μπορούν να έχουν Εκατοντάδες Χιλιάδες (ΕΧ), Δεκάδες Χιλιάδες (ΔΧ), Μονάδες Χιλιάδες (ΜΧ), Εκατοντάδες (Ε), Δεκάδες (Δ) και Μονάδες (Μ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };

        problem = "Όταν θέλουμε να γράψουμε έναν πενταψήφιο αριθμό, γράφουμε πρώτα το ψηφίο των ... , Δεκάδων Χιλιάδων (ΔΧ), μετά των Μονάδων Χιλιάδων (ΜΧ), μετά των Εκατοντάδων (Ε), μετά των Δεκάδων (Δ) και μετά των Μονάδων (Μ)";
        correctindex = 1;
        answers = new string[] { "Μονάδων Εκατομμυρίων (ΜΕ)", "Εκατοντάδων Χιλιάδων (ΕΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δέκα μονάδες μια τάξης (π.χ. δέκα εκατοντάδες) συμπληρώνουν μια μονάδα της επόμενης τάξης (π.χ. 1 μονάδα χιλιάδων)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 100.000 είναι πενταψήφιος";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Στον αριθμό 65.002 το 6 είναι";
        correctindex = 0;
        answers = new string[] { "Δεκάδες Χιλιάδες (ΔΧ)", "Μονάδες Χιλιάδες (ΜΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός ογδόντα πέντε χιλιάδες διακόσια δύο γράφεται";
        correctindex = 0;
        answers = new string[] { "85202", "8500202" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 δεκάδες = 1 Εκατοντάδα Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Η ανάλυση ενός αριθμού μέσω της αξία του κάθε ψηφίου λέγεται";
        correctindex = 1;
        answers = new string[] { "ανάλυση του αριθμού σε άθροισμα", "δεκαδικό ανάπτυγμα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν συκρίνουμε δύο αριθμούς , ξεκινάμε πάντα από το ψηφίο που έχει τη μεγαλύτερη αξία (το πρώτο από αριστερά). Αν είναι ίσο, προχωράμε στο αμέσως επόμενο";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να διαβάσουμε μεγάλους αριθμούς, τους χωρίζουμε ανά ... ψηφία με μια τελεία, ξεκινώντας από το τέλος του";
        correctindex = 0;
        answers = new string[] { "τρία", "τέσσερα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε έναν αριθμό το ίδιο ψηφίο έχει διαφορετική αξία ανάλογα με τη θέση του";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 95.067 αναλύεται σε δεκαδικό ανάπτυγμα ως 9x10.000+5x ... +6x10+7x1";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "56.302<56.039 Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν γράφω τον αριθμό σαράντα πέντε χιλιάδες εξακόσια δύο η τελεία μπαίνει (κοιτάζοντας τον αριθμό από τα δεξιά προς τα αριστερά)";
        correctindex = 1;
        answers = new string[] { "μετά το 5", "μετά το 6" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 6 έχει μικρότερη αξία;";
        correctindex = 0;
        answers = new string[] { "50.654", "56.208" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "200 δεκάδες είναι ίσες με ... εκατοντάδες";
        correctindex = 1;
        answers = new string[] { "2", "20" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 65.100 έχει 6";
        correctindex = 0;
        answers = new string[] { "Δεκάδες Χιλιάδες (ΔΧ)", "Μονάδες Χιλιάδες (ΜΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό έχει μεγαλύτερη αξία το 8;";
        correctindex = 1;
        answers = new string[] { "98.035", "89.700" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "10 μονάδες χιλιάδες συμπληρώνουν 10 δεκάδες χιλιάδες;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 30.020-30.040-...";
        correctindex = 0;
        answers = new string[] { "30.050", "30.060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 100.000. Ποιός είναι ο προηγούμενος;";
        correctindex = 1;
        answers = new string[] { "999.999", "99.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 45.000. Ποιός είναι ο διπλάσιος του;";
        correctindex = 1;
        answers = new string[] { "85.000", "90.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός είκοσι επτά χιλιάδες οκτακόσια τριάντα γράφεται";
        correctindex = 0;
        answers = new string[] { "27.830", "27.083" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "98.080>98.0..0 Συμπλήρωσε το ψηφίο";
        correctindex = 1;
        answers = new string[] { "9", "1" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η σωστή σειρά των αριθμών α.87.654 β.45.008 γ.78.956 δ.87.664 από τον μικρότερο στον μεγαλύτερο;";
        correctindex = 1;
        answers = new string[] { "β-γ-α-δ", "β-γ-δ-α" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "6x ... = 60.000 Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "10.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "14.670+3.580 = ... Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "18.250", "17.250" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));



        //Μαθηματικά Προβλήματα Δ Δημοτικού Κεφ.37 Αριθμοί μέχρι το 200.000

        problem = "Εξαψήφιοι ονομάζονται οι αριθμοί που έχουν ... ψηφία";
        correctindex = 0;
        answers = new string[] { "έξι", "πέντε" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Οι εξαψήφιοι αριθμοί μπορούν να έχουν Εκατοντάδες Χιλιάδες (ΕΧ), Δεκάδες Χιλιάδες (ΔΧ), Μονάδες Χιλιάδες (ΜΧ), Εκατοντάδες (Ε), Δεκάδες (Δ) και Μονάδες (Μ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν θέλουμε να γράψουμε έναν πενταψήφιο αριθμό, γράφουμε πρώτα το ψηφίο των ... (ΕΧ), Δεκάδων Χιλιάδων (ΔΧ), μετά των Μονάδων Χιλιάδων (ΜΧ), μετά των Εκατοντάδων (Ε), μετά των Δεκάδων (Δ) και μετά των Μονάδων (Μ)";
        correctindex = 1;
        answers = new string[] { "Δεκάδων Χιλιάδων (ΔΧ)", "Εκατοντάδων Χιλιάδων (ΕΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δέκα μονάδες μια τάξης (π.χ. δέκα εκατοντάδες) συμπληρώνουν μια μονάδα της επόμενης τάξης (π.χ. 1 μονάδα χιλιάδων)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το ... είναι ένας εξαψήφιος αριθμός";
        correctindex = 1;
        answers = new string[] { "100.004", "12.980" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 136.567 έχει 1";
        correctindex = 1;
        answers = new string[] { "Δεκάδα Χιλιάδα (ΔΧ)", "Εκατοντάδα Χιλιάδα (ΕΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός εκατόν πενήντα χιλιάδες γράφεται";
        correctindex = 0;
        answers = new string[] { "150000", "1500000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δέκα δεκάδες χιλιάδες συμπληρώνουν μια μονάδα χιλιάδα";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Για να συγκρίνουμε δύο αριθμούς ξεκινάμε πρώτα από το ψηφίο που είχε την μεγαλύτερη αξία (το πρώτο από αριστερά). Αν είναι το ίδιο προχωράμε στο αμέσως επόμενο";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δεκαδικό ανάπτυγμα είναι η ανάλυση του αριθμού μέσω της αξίας κάθε ψηφίου";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δεκαδικό ανάπτυγμα είναι η ανάλυση του αριθμού μέσω της αξίας κάθε ψηφίου";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 χιλιάδες ή 100 φορές από 1.000. Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "100 Σε έναν αριθμό το ίδιο ψηφίο έχει διαφορετική αξία ανάλογα με τη θέση του";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "205.176>208.053 Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 1x100.000+5x10.000+1x1.000+1x10+5x1 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "151.105", "151.015" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 10.000 είναι ίσος με ... δεκάδες ή ... φορές το 10";
        correctindex = 1;
        answers = new string[] { "100", "1.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000 εκατοντάδες = 1 εκατοντάδα χιλιάδα Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός εκατό χιλιάδες διακόσια πέντε γράφεται ως";
        correctindex = 0;
        answers = new string[] { "100.205", "100.000.205" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 105.690 έχει 1";
        correctindex = 0;
        answers = new string[] { "Εκατοντάδα Χίλιάδα (ΕΧ)", "Δεκάδα Χιλιάδα (ΔΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δέκα δεκάδες χιλιάδες συμπληρώνουν 1 ... ";
        correctindex = 0;
        answers = new string[] { "Εκατοντάδα Χίλιάδα (ΕΧ)", "Δεκάδα Χιλιάδα (ΔΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα του αριθμού 100.050 είναι";
        correctindex = 1;
        answers = new string[] { "1x100.000+50x10", "1x100.000+5x10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 135.200-135.800- ...";
        correctindex = 0;
        answers = new string[] { "136.200", "136.400" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Πόσο κάνει 3x40.000;";
        correctindex = 0;
        answers = new string[] { "120.000", "12.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 116.000. Ποιός είναι ο προηγούμενος;";
        correctindex = 1;
        answers = new string[] { "115.000", "115.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 1x100.000+4x10.000+9x1.000+5x10 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "149.050", "149.005" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό τον 7 έχει μεγαλύτερη αξία;";
        correctindex = 1;
        answers = new string[] { "197.856", "176.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "1.000 εκατοντάδες = 1 εκατοντάδα χιλιάδα Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιά η σωστή σειρά των αριθμών α.101.234 β.100.251 γ.110.008 δ.101.432 από τον μικρότερο στο μεγαλύτερο;";
        correctindex = 0;
        answers = new string[] { "β-α-δ-γ", "β-δ-α-γ" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Πώς γράφεται ο αριθμός εκατό χιλιάδες πεντακόσια πέντε;";
        correctindex = 1;
        answers = new string[] { "150.005", "100.505" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το διπλάσιο του αριθμού 100.005 είναι";
        correctindex = 1;
        answers = new string[] { "200.100", "200.010" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Έχω τον αριθμό 50.000. Αν προσθέσω εκατό χιλιάδες, ποιός αριθμός προκύπτει;";
        correctindex = 0;
        answers = new string[] { "150.000", "510.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "165.628>165.691 Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "120.000 : ...=60.000";
        correctindex = 0;
        answers = new string[] { "2", "6" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //Μαθηματικά Προβλήματα Δ Δημοτικού Κεφ.47 Αριθμοί μέχρι το 1.000.000

        problem = "Ένας επταψήφιος αριθμός (π.χ. 1.000.000) μπορεί να έχει Μονάδες Εκατομμυρίων (ΜΕ), Εκατοντάδες Χιλιάδες (ΕΧ), Δεκάδες Χιλιάδες (ΔΧ), Μονάδες Χιλιάδες (ΜΧ), Εκατοντάδες (Ε), Δεκάδες (Δ) και Μονάδες (Μ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το ψηφίο των Εκατομμυρίων ή Μονάδων Εκατομμυρίων (ΜΕ) είναι 10 φορές μεγαλύτερο από εκείνο των Εκατοντάδων Χιλιάδων (ΕΧ).";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το ψηφίο των Εκατομμυρίων ή Μονάδων Εκατομμυρίων (ΜΕ) είναι 100 φορές μεγαλύτερο από εκείνο των Δεκάδων Χιλιάδων (ΔΧ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το ψηφίο των Εκατομμυρίων ή Μονάδων Εκατομμυρίων (ΜΕ) είναι 1.000 φορές μεγαλύτερο από εκείνο των Μονάδων Χιλιάδων (ΜΧ)";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 956.000 έχει 5";
        correctindex = 0;
        answers = new string[] { "Δεκάδες Χιλιάδες (ΔΧ)", "Εκατοντάδες Χιλιάδες (ΕΧ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Εκατοντάδες Χιλιάδες ή ... φορές το 100.000";
        correctindex = 1;
        answers = new string[] { "100", "10" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Δεκάδες Χιλιάδες ή ... φορές από 10.000";
        correctindex = 1;
        answers = new string[] { "10", "100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Χιλιάδες ή ... φορές από 1.000";
        correctindex = 1;
        answers = new string[] { "10.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Η ανάλυση του σε μονάδες, δεκάδες, εκατοντάδες, χιλιάδες δηλαδή μέσω της αξίας κάθε ψηφίου ονομάζεται";
        correctindex = 0;
        answers = new string[] { "δεκαδικό ανάπτυγμα", "ανάλυση σε άθροισμα" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Όταν θέλουμε να συγκρίνουμε δύο αριθμούς ξεκινάμε από το ψηφίο που βρίσκεται πρώτο από δεξιά. Αν είναι ίδιο συνεχίζουμε στο αμέσως επόμενο.";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε έναν αριθμό το ίδιο ψηφίο έχει διαφορετική αξία ανάλογα με τη θέση του";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.054.650 αναλύεται σε δεκαδικό ανάπτυγμα ως 1x100.000.000+5x1.000+4x100+6x10+5x1";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "965.567>1.000.000 Σωστό ή Λάθος;";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 6 έχει μεγαλύτερη αξία;";
        correctindex = 0;
        answers = new string[] { "560.000", "786.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Εκατοντάδες ή ... φορές από 100";
        correctindex = 1;
        answers = new string[] { "100", "10.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Μονάδες";
        correctindex = 0;
        answers = new string[] { "1.000.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι ίσος με ... Δεκάδες ή ... φορές από 10";
        correctindex = 1;
        answers = new string[] { "1.000.000", "100.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 6x1.000.000+7x10.000+3X10+8x1 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "6.070.031", "6.731.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Συνέχισε το αριθμητικό μοτίβο 800.000-900.000- ...";
        correctindex = 1;
        answers = new string[] { "1000.000", "1.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "7...0.869>710.100 Συμπλήρωσε τον αριθμό για να ισχύει η ισότητα";
        correctindex = 0;
        answers = new string[] { "1", "0" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποια η σωστή σειρά των αριθμών α.900.100 β.900.010 γ.901.000 δ.910.000 από τον μεγαλύτερο στον μικρότερο;";
        correctindex = 1;
        answers = new string[] { "δ-γ-β-α", "δ-γ-α-β" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 έχει 1";
        correctindex = 0;
        answers = new string[] { "Μονάδα Εκατομμυρίων (ΜΕ)", "Δεκάδα Εκατομμυρίων (ΔΕ)" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Σε ποιόν αριθμό το 6 έχει μεγαλύτερη αξία;";
        correctindex = 1;
        answers = new string[] { "860.000", "610.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το μισό του 600.000 είναι";
        correctindex = 0;
        answers = new string[] { "300.000", "200.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το τριπλάσιο του 300.000 είναι";
        correctindex = 0;
        answers = new string[] { "900000", "90.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "240.000+ ... = 620.000 Συμπλήρωσε την ισότητα";
        correctindex = 1;
        answers = new string[] { "360.000", "380.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "... x 3 = 180.000 Συμπλήρωσε την ισότητα";
        correctindex = 0;
        answers = new string[] { "60.000", "6.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιός αριθμός είναι ανάμεσα στο 654.010 και το 655.010";
        correctindex = 0;
        answers = new string[] { "654.000", "655.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το δεκαδικό ανάπτυγμα 5x100.000+8x10.000+6x1 μας δίνει τον αριθμό";
        correctindex = 0;
        answers = new string[] { "580.001", "581.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιός είναι ο προηγούμενος αριθμός του 600.000;";
        correctindex = 1;
        answers = new string[] { "599.000", "599.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


        //Μαθηματικά Προβλήματα Ε δημοτικού Κεφ.3 Φυσικοί αριθμοί

        problem = "Οι αριθμοί 0,1,2,3,...,100,101,...,1.000,1.000.000.... λέγονται φυσικοί αριθμοί";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "’ρτιοι είναι οι αριθμοί που ανήκουν στην προπαίδεια του 2";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Οι ενδιάμεσοι από τους άρτιους είναι οι περιττοί αριθμοί";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Κάθε φυσικός αριθμός έχει έναν επόμενο και ένα προηγούμενο εκτός από το 0 που δεν έχει προηγούμενο";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 1.000.000 είναι";
        correctindex = 0;
        answers = new string[] { "εξαψήφιος", "επταψήφιος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο φυσικός αριθμός 300.005 είναι άρτιος";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο φυσικός αριθμός 650.000 είναι περιττός";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο προηγούμενος αριθμός του 10.000.000 είναι";
        correctindex = 1;
        answers = new string[] { "99.999.999", "9.999.999" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ανάμεσα στο 6 και το 8 δεν υπάρχει περιττός αριθμός";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 0 είναι ο μικρότερος φυσικός αριθμός";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Δεν υπάρχει μεγαλύτερος φυσικός αριθμός και για κάθε φυσικό αριθμό υπάρχει ο επόμενός του";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ανάμεσα στο 4 και το 5 υπάρχει φυσικός αριθμός";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 80.002 είναι ... φυσικός αριθμός";
        correctindex = 0;
        answers = new string[] { "άρτιος", "περιττός" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 1.000 είναι ο μεγαλύτερος τετραψήφιος φυσικός αριθμός";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο επόμενος αριθμός του 99.099 είναι";
        correctindex = 1; 
        answers = new string[] { "100.000", "99.100" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός επτακόσιες χιλιάδες πεντακόσια εξήντα γράφεται ως";
        correctindex = 0;
        answers = new string[] { "700.560", "705.060" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 950.002 είναι άρτιος αριθμός";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το 100.000 είναι ο ... εξαψήφιος αριθμός";
        correctindex = 0;
        answers = new string[] { "μικρότερος", "μεγαλύτερος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιός είναι ο επόμενος αριθμός του 590.999;";
        correctindex = 1;
        answers = new string[] { "600.000", "591.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός ένα εκατομμύριο εξήντα πέντε γράφεται";
        correctindex = 1;
        answers = new string[] { "1.065.000", "1.000.065" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "765.234 ... 756.999 Συμπλήρωσε την ισότητα";
        correctindex = 1;
        answers = new string[] { "<", ">" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός δέκα δισεκατομμύρια γράφεται ως";
        correctindex = 0;
        answers = new string[] { "10.000.000.000", "10.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 654.000 είναι άρτιος";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο αριθμός 654.000 είναι περιττός";
        correctindex = 1;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το μισό του 1.000.000 είναι";
        correctindex = 1;
        answers = new string[] { "5.000.000", "500.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Το διπλάσιο του 3.000.000 είναι";
        correctindex = 1;
        answers = new string[] { "9.000.000", "6.000.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Βάζω τους αριθμούς από τον μικρότερο στον μεγαλύτερο α.6.980.000 β.6.890.00 γ.6.089.000 δ.6.809.000";
        correctindex = 1;
        answers = new string[] { "γ-δ-β-α", "γ-β-δ-α" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ποιός είναι ο μεικτός αριθμός 13 εκατομμύρια 40 μονάδες;";
        correctindex = 0;
        answers = new string[] { "13.000.040", "13.000.000.040" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "350 εκατομμύρια 25 χιλιάδες = 350.025.000 Σωστό ή Λάθος;";
        correctindex = 0;
        answers = new string[] { "Σωστό", "Λάθος" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "200 εκατομμύρια, 20 χιλιάδες έχει ο αριθμός";
        correctindex = 1;
        answers = new string[] { "200.000.020", "200.020.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο επόμενος αριθμός του 3.009.000 είναι";
        correctindex = 1;
        answers = new string[] { "3.009.001", "3.010.000" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));

        problem = "Ο προηγούμενος αριθμός του 9.000.900 είναι";
        correctindex = 1;
        answers = new string[] { "9.000.800", "9.000.899" };
        MathProblems.Add(new MathProblem(problem, answers, correctindex));


}
    //#region MATHPROBLEM class
    //public class MathProblem
    //{

    //    public string Problem = null;
    //    public string[] Answers = null;
    //    public int CorrectAnswerIndex = 0;

    //    public MathProblem(string problem, string[] answers, int correctindex)
    //    {
    //        Problem = problem;
    //        Answers = answers;
    //        CorrectAnswerIndex = correctindex;
    //    }

    //}
    //#endregion
}
