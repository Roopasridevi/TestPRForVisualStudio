// testing 2026 Sprint 2
// test V2.1.2

using System;

public class CsharpFileSvg
{
    private const string SVG_CONTENT = @"
        <svg width='24' height='24' viewBox='0 0 24 24' fill='none' xmlns='http://www.w3.org/2000/svg'>
            <rect x='3' y='2' width='18' height='20' rx='2' fill='#239120'/>
            <text x='12' y='14' text-anchor='middle' fill='white' font-family='Arial, sans-serif' font-size='8' font-weight='bold'>C#</text>
        </svg>
    ";

    public static string GetSvgContent()
    {
        return SVG_CONTENT;
    }
}